#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc
// Filename:    IfcInstances.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Diagnostics;
using Xbim.Common;
using Xbim.Ifc2x3.Kernel;

#endregion

namespace Xbim.IO
{
    public class ExpressMetaProperty
    {
        public PropertyInfo PropertyInfo;
        public EntityAttributeAttribute EntityAttributeAttribute;
    }

    /// <summary>
    ///   A collection of IPersistEntity instances, optimised for IFC models
    /// </summary>
    [Serializable]
    public class ExpressMetaData
    {
        /// <summary>
        /// Look up for the if of an Ifc entity that returns the IfcType
        /// </summary>
        private static readonly Dictionary<short, ExpressType> TypeIdToExpressTypeLookup = new Dictionary<short, ExpressType>();
        /// <summary>
        /// Look up the entity Type and return the IfcType
        /// </summary>
        private static readonly ExpressTypeDictionary TypeToExpressTypeLookup;
        /// <summary>
        /// Look up the name of an ifc entity and return the IfcType
        /// </summary>
        private static readonly Dictionary<string, ExpressType> TypeNameToExpressTypeLookup;
        /// <summary>
        /// Look up the name of an ifc entity and return the IfcType
        /// </summary>
        private static readonly Dictionary<string, ExpressType> EntityNameToExpressTypeLookup;
        /// <summary>
        /// Look up IfcTypes implementing an interface
        /// </summary>
        private static readonly Dictionary<Type, List<ExpressType>> InterfaceToExpressTypesLookup;

        static ExpressMetaData()
        {
            var module = typeof(IfcActor).Module;
            var typesToProcess =
                module.GetTypes().Where(
                    t =>
                    typeof(IPersist).IsAssignableFrom(t) && t != typeof(IPersist) && !t.IsEnum && !t.IsAbstract &&
                    t.IsPublic && !typeof(IExpressHeaderType).IsAssignableFrom(t)).ToList();

            TypeNameToExpressTypeLookup = new Dictionary<string, ExpressType>(typesToProcess.Count);
            EntityNameToExpressTypeLookup = new Dictionary<string, ExpressType>(typesToProcess.Count);
            TypeToExpressTypeLookup = new ExpressTypeDictionary();
            InterfaceToExpressTypesLookup = new Dictionary<Type, List<ExpressType>>();
            try
            {
                // System.Diagnostics.Debug.Write(typesToProcess.Count());
                foreach (var typeToProcess in typesToProcess)
                {
                    // Debug.WriteLine(typeToProcess.ToString());
                    ExpressType expressTypeToProcess;
                    if (TypeToExpressTypeLookup.Contains(typeToProcess))
                        expressTypeToProcess = TypeToExpressTypeLookup[typeToProcess];
                    else
                    {
                        var ifcTypeIndex = (IndexedClass[])typeToProcess.GetCustomAttributes(typeof(IndexedClass), true);
                        expressTypeToProcess = new ExpressType { Type = typeToProcess, IndexedClass = (ifcTypeIndex.GetLength(0) > 0) };
                    }

                    var typeLookup = typeToProcess.Name.ToUpperInvariant();
                    if (!TypeNameToExpressTypeLookup.ContainsKey(typeLookup))
                        TypeNameToExpressTypeLookup.Add(typeLookup, expressTypeToProcess);

                    if (typeof (IPersistEntity).IsAssignableFrom(typeToProcess))
                    {
                        EntityNameToExpressTypeLookup.Add(expressTypeToProcess.ExpressName, expressTypeToProcess);
                        TypeIdToExpressTypeLookup.Add(expressTypeToProcess.TypeId, expressTypeToProcess);
                    }

                    if (!TypeToExpressTypeLookup.Contains(expressTypeToProcess))
                    {
                        TypeToExpressTypeLookup.Add(expressTypeToProcess);
                        AddParent(expressTypeToProcess);
                        AddProperties(expressTypeToProcess);
                    }

                    // populate the dictionary lookup by interface
                    //
                    foreach (var interfaceFound in typeToProcess.GetInterfaces())
                    {
                        if (!interfaceFound.Namespace.StartsWith("Xbim"))
                            continue;
                        if (interfaceFound.Name == "IfcMaterialSelect")
                        {
                        }
                        if (!InterfaceToExpressTypesLookup.ContainsKey(interfaceFound))
                        {
                            // add to dictionary
                            InterfaceToExpressTypesLookup.Add(interfaceFound, new List<ExpressType>());
                        }
                        InterfaceToExpressTypesLookup[interfaceFound].Add(expressTypeToProcess);
                    }
                }

                // add the index property to abstract types
                //
                foreach (var ifcType in TypeToExpressTypeLookup.Where(t => t.Type.IsAbstract))
                {
                    var ifcTypeIndex = (IndexedClass[])ifcType.Type.GetCustomAttributes(typeof(IndexedClass), true);
                    ifcType.IndexedClass = (ifcTypeIndex.GetLength(0) > 0);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error reading Ifc Entity Meta Data", e);
            }
            //foreach (var item in TypeNameToIfcTypeLookup)
            //{
            //    if (!item.Value.Type.IsAbstract && !item.Value.Type.IsValueType && !typeof(Xbim.Ifc2x3.GeometryResource.IfcRepresentationItem).IsAssignableFrom( item.Value.Type))
            //    {
            //        if (!item.Value.IndexedClass) Debug.WriteLine(item.Key + " = " + item.Value.IndexedClass);
            //    }
            //}
        }

        internal static void AddProperties(ExpressType expressType)
        {
            var properties =
                expressType.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
            foreach (var propInfo in properties)
            {
                var attributeIdx = -1;
                var ifcAttributes =
                    (EntityAttributeAttribute[])propInfo.GetCustomAttributes(typeof(EntityAttributeAttribute), false);
                if (ifcAttributes.GetLength(0) > 0) //we have an ifc property
                {
                    if (ifcAttributes[0].Order > 0)
                    {
                        // SUPPORT: if the code breaks here there's a problem with the order attribut in a class property
                        expressType.Properties.Add(ifcAttributes[0].Order,
                                                    new ExpressMetaProperty { PropertyInfo = propInfo, EntityAttributeAttribute = ifcAttributes[0] });
                        attributeIdx = ifcAttributes[0].Order;                     
                    }

                    else
                        expressType.Inverses.Add(new ExpressMetaProperty { PropertyInfo = propInfo, EntityAttributeAttribute = ifcAttributes[0] });
                }
                var ifcIndexes =
                    (IndexedProperty[])propInfo.GetCustomAttributes(typeof(IndexedProperty), false);
                if (ifcIndexes.GetLength(0) > 0) //we have an index
                {
                    Debug.Assert(typeof(IPersistEntity).IsAssignableFrom(propInfo.PropertyType)
                        || typeof(IEnumerable<IPersistEntity>).IsAssignableFrom(propInfo.PropertyType)); //only handles to IPersistIfcEntitiess or collecctions of IPersistIfcEntities are indexable
                    expressType.AddIndexedAttribute(propInfo, attributeIdx);
                }
            }
        }


        internal static void AddParent(ExpressType child)
        {
            var baseParent = child.Type.BaseType;
            if (baseParent == null || typeof(object) == baseParent || typeof(ValueType) == baseParent)
                return;
            ExpressType expressParent;
            if (!TypeToExpressTypeLookup.Contains(baseParent))
            {
                TypeToExpressTypeLookup.Add(expressParent = new ExpressType { Type = baseParent });
                var typeLookup = baseParent.Name.ToUpper();
                if (!TypeNameToExpressTypeLookup.ContainsKey(typeLookup))
                    TypeNameToExpressTypeLookup.Add(typeLookup, expressParent);
                expressParent.SubTypes.Add(child);
                child.SuperType = expressParent;
                AddParent(expressParent);
                AddProperties(expressParent);
            }
            else
            {
                expressParent = TypeToExpressTypeLookup[baseParent];
                child.SuperType = expressParent;
                if (!expressParent.SubTypes.Contains(child))
                    expressParent.SubTypes.Add(child);
            }
        }

        public static IEnumerable<ExpressType> Types()
        {
            return TypeNameToExpressTypeLookup.Keys.Select(item => TypeNameToExpressTypeLookup[item]);
        }

        /// <summary>
        /// Returns the IfcType with the specified name (name of type or express name)
        /// </summary>
        /// <param name="typeName">The name of the type in uppercase</param>
        /// <returns>The foud type (or Null if not found)</returns>
        public static ExpressType IfcType(string typeName)
        {
            if (TypeNameToExpressTypeLookup.ContainsKey(typeName))
                return TypeNameToExpressTypeLookup[typeName];
            if (EntityNameToExpressTypeLookup.ContainsKey(typeName))
                return TypeNameToExpressTypeLookup[typeName];
            return null;
        }

        public static IEnumerable<ExpressType> IfcTypesImplementing(Type type)
        {
            if (!InterfaceToExpressTypesLookup.ContainsKey(type)) yield break;
            foreach (var item in InterfaceToExpressTypesLookup[type])
                yield return item;
        }

        public static IEnumerable<Type> TypesImplementing(Type type)
        {
            if (!InterfaceToExpressTypesLookup.ContainsKey(type)) yield break;
            foreach (var item in InterfaceToExpressTypesLookup[type])
                yield return item.Type;
        }

        public static IEnumerable<ExpressType> TypesImplementing(string stringType)
        {
            var dictitem = InterfaceToExpressTypesLookup.Keys.FirstOrDefault(intf => String.Equals(intf.Name, stringType, StringComparison.InvariantCultureIgnoreCase));
            if (dictitem == null) yield break;
            foreach (var item in InterfaceToExpressTypesLookup[dictitem])
            {
                yield return item;
            }
        }

        /// <summary>
        /// Returns the IfcType with the specified type
        /// </summary>
        /// <param name="type">The type</param>
        /// <returns>The foud type (or Null if not found)</returns>
        public static ExpressType IfcType(Type type)
        {
            if (TypeToExpressTypeLookup.Contains(type))
                return TypeToExpressTypeLookup[type];
            return
                null;
        }

        /// <summary>
        /// returns the IfcType corresponding to the TypeId
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static ExpressType IfcType(short typeId)
        {
            return TypeIdToExpressTypeLookup[typeId];
        }

        /// <summary>
        /// returns the ifc type id of the type, if the type is not an ifc entity and excpetion will be thrown
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static short IfcTypeId(Type type)
        {
            return TypeToExpressTypeLookup[type].TypeId;
        }
        /// <summary>
        /// Returns the ifc typeId for the named type
        /// </summary>
        /// <param name="typeName">the name of the type, this is in uppercase</param>
        /// <returns></returns>
        public static short IfcTypeId(string typeName)
        {
            return TypeNameToExpressTypeLookup[typeName].TypeId;
        }

        public static short IfcTypeId(IPersist entity)
        {
            return TypeToExpressTypeLookup[entity.GetType()].TypeId;
        }

        /// <summary>
        /// Returns the Type of the Ifc Entity with typeId
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static Type GetType(short typeId)
        {
            return IfcType(typeId).Type;
        }

        /// <summary>
        /// Returns the IfcType of the specified entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static ExpressType IfcType(IPersist entity)
        {
            return TypeToExpressTypeLookup[entity.GetType()];
        }


        /// <summary>
        /// Trys to get the specified Ifc Type with the typeName, if the ifcType does not exist false is returned
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="expressType"></param>
        /// <returns></returns>
        public static bool TryGetExpressType(string typeName, out ExpressType expressType)
        {
            return TypeNameToExpressTypeLookup.TryGetValue(typeName, out expressType);
        }

        /// <summary>
        /// Returns true if the named entities attribute is indexed
        /// </summary>
        /// <param name="entityTypeName">the name of the Ifc Entity</param>
        /// <param name="attributeIndex">the index offset of the attribute to check, nb this is a 1 based index</param>
        /// <returns></returns>
        public static bool IsIndexedIfcAttribute(string entityTypeName, int attributeIndex)
        {
            var ifcType = IfcType(entityTypeName);
            return ifcType.IsIndexedIfcAttribute(attributeIndex);
        }

        public static void Load()
        {
            foreach (var item in TypeNameToExpressTypeLookup.Values)
            {
                var l = item.NonAbstractSubTypes;
            }
        }

        
    }
}