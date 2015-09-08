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
using Xbim.XbimExtensions.Interfaces;
using Xbim.XbimExtensions;
using System.Diagnostics;
using Xbim.Common;
using Xbim.Common.XbimExtensions;
using Xbim.Ifc2x3.Kernel;

#endregion

namespace Xbim.IO
{
    public class IfcMetaProperty
    {
        public PropertyInfo PropertyInfo;
        public IfcAttribute IfcAttribute;
    }

    /// <summary>
    ///   A collection of IPersistEntity instances, optimised for IFC models
    /// </summary>
    [Serializable]
    public class IfcMetaData
    {
        /// <summary>
        /// Look up for the if of an Ifc entity that returns the IfcType
        /// </summary>
        private static Dictionary<short, IfcType> _typeIdToIfcTypeLookup = new Dictionary<short, IfcType>();
        /// <summary>
        /// Look up the entity Type and return the IfcType
        /// </summary>
        private static IfcTypeDictionary _typeToIfcTypeLookup;
        /// <summary>
        /// Look up the name of an ifc entity and return the IfcType
        /// </summary>
        private static Dictionary<string, IfcType> _typeNameToIfcTypeLookup;
        /// <summary>
        /// Look up the name of an ifc entity and return the IfcType
        /// </summary>
        private static Dictionary<string, IfcType> _entityNameToIfcTypeLookup;
        /// <summary>
        /// Look up IfcTypes implementing an interface
        /// </summary>
        private static Dictionary<Type, List<IfcType>> _interfaceToIfcTypesLookup;

        static IfcMetaData()
        {
            var ifcModule = typeof(IfcActor).Module;
            var typesToProcess =
                ifcModule.GetTypes().Where(
                    t =>
                    typeof(IPersist).IsAssignableFrom(t) && t != typeof(IPersist) && !t.IsEnum && !t.IsAbstract &&
                    t.IsPublic && !typeof(IExpressHeaderType).IsAssignableFrom(t)).ToList();

            _typeNameToIfcTypeLookup = new Dictionary<string, IfcType>(typesToProcess.Count);
            _entityNameToIfcTypeLookup = new Dictionary<string, IfcType>(typesToProcess.Count);
            _typeToIfcTypeLookup = new IfcTypeDictionary();
            _interfaceToIfcTypesLookup = new Dictionary<Type, List<IfcType>>();
            try
            {
                // System.Diagnostics.Debug.Write(typesToProcess.Count());
                foreach (var typeToProcess in typesToProcess)
                {
                    // Debug.WriteLine(typeToProcess.ToString());
                    IfcType ifcTypeToProcess;
                    if (_typeToIfcTypeLookup.Contains(typeToProcess))
                        ifcTypeToProcess = _typeToIfcTypeLookup[typeToProcess];
                    else
                    {
                        var ifcTypeIndex = (IndexedClass[])typeToProcess.GetCustomAttributes(typeof(IndexedClass), true);
                        ifcTypeToProcess = new IfcType { Type = typeToProcess, IndexedClass = (ifcTypeIndex.GetLength(0) > 0) };
                    }

                    var typeLookup = typeToProcess.Name.ToUpperInvariant();
                    if (!_typeNameToIfcTypeLookup.ContainsKey(typeLookup))
                        _typeNameToIfcTypeLookup.Add(typeLookup, ifcTypeToProcess);

                    if (typeof (IPersistEntity).IsAssignableFrom(typeToProcess))
                    {
                        _entityNameToIfcTypeLookup.Add(ifcTypeToProcess.ExpressName, ifcTypeToProcess);
                        _typeIdToIfcTypeLookup.Add(ifcTypeToProcess.TypeId, ifcTypeToProcess);
                    }

                    if (!_typeToIfcTypeLookup.Contains(ifcTypeToProcess))
                    {
                        _typeToIfcTypeLookup.Add(ifcTypeToProcess);
                        AddParent(ifcTypeToProcess);
                        AddProperties(ifcTypeToProcess);
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
                        if (!_interfaceToIfcTypesLookup.ContainsKey(interfaceFound))
                        {
                            // add to dictionary
                            _interfaceToIfcTypesLookup.Add(interfaceFound, new List<IfcType>());
                        }
                        _interfaceToIfcTypesLookup[interfaceFound].Add(ifcTypeToProcess);
                    }
                }

                // add the index property to abstract types
                //
                foreach (var ifcType in _typeToIfcTypeLookup.Where(t => t.Type.IsAbstract))
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

        internal static void AddProperties(IfcType ifcType)
        {
            var properties =
                ifcType.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
            foreach (var propInfo in properties)
            {
                var attributeIdx = -1;
                var ifcAttributes =
                    (IfcAttribute[])propInfo.GetCustomAttributes(typeof(IfcAttribute), false);
                if (ifcAttributes.GetLength(0) > 0) //we have an ifc property
                {
                    if (ifcAttributes[0].Order > 0)
                    {
                        // SUPPORT: if the code breaks here there's a problem with the order attribut in a class property
                        ifcType.IfcProperties.Add(ifcAttributes[0].Order,
                                                    new IfcMetaProperty { PropertyInfo = propInfo, IfcAttribute = ifcAttributes[0] });
                        attributeIdx = ifcAttributes[0].Order;                     
                    }

                    else
                        ifcType.IfcInverses.Add(new IfcMetaProperty { PropertyInfo = propInfo, IfcAttribute = ifcAttributes[0] });
                }
                var ifcIndexes =
                    (IndexedProperty[])propInfo.GetCustomAttributes(typeof(IndexedProperty), false);
                if (ifcIndexes.GetLength(0) > 0) //we have an index
                {
                    Debug.Assert(typeof(IPersistEntity).IsAssignableFrom(propInfo.PropertyType)
                        || typeof(IEnumerable<IPersistEntity>).IsAssignableFrom(propInfo.PropertyType)); //only handles to IPersistIfcEntitiess or collecctions of IPersistIfcEntities are indexable
                    ifcType.AddIndexedAttribute(propInfo, attributeIdx);
                }
            }
        }


        internal static void AddParent(IfcType child)
        {
            var baseParent = child.Type.BaseType;
            if (baseParent == null || typeof(object) == baseParent || typeof(ValueType) == baseParent)
                return;
            IfcType ifcParent;
            if (!_typeToIfcTypeLookup.Contains(baseParent))
            {
                _typeToIfcTypeLookup.Add(ifcParent = new IfcType { Type = baseParent });
                var typeLookup = baseParent.Name.ToUpper();
                if (!_typeNameToIfcTypeLookup.ContainsKey(typeLookup))
                    _typeNameToIfcTypeLookup.Add(typeLookup, ifcParent);
                ifcParent.IfcSubTypes.Add(child);
                child.IfcSuperType = ifcParent;
                AddParent(ifcParent);
                AddProperties(ifcParent);
            }
            else
            {
                ifcParent = _typeToIfcTypeLookup[baseParent];
                child.IfcSuperType = ifcParent;
                if (!ifcParent.IfcSubTypes.Contains(child))
                    ifcParent.IfcSubTypes.Add(child);
            }
        }

        public static IEnumerable<IfcType> Types()
        {
            return _typeNameToIfcTypeLookup.Keys.Select(item => _typeNameToIfcTypeLookup[item]);
        }

        /// <summary>
        /// Returns the IfcType with the specified name (name of type or express name)
        /// </summary>
        /// <param name="typeName">The name of the type in uppercase</param>
        /// <returns>The foud type (or Null if not found)</returns>
        public static IfcType IfcType(string typeName)
        {
            if (_typeNameToIfcTypeLookup.ContainsKey(typeName))
                return _typeNameToIfcTypeLookup[typeName];
            if (_entityNameToIfcTypeLookup.ContainsKey(typeName))
                return _typeNameToIfcTypeLookup[typeName];
            return null;
        }

        public static IEnumerable<IfcType> IfcTypesImplementing(Type type)
        {
            if (!_interfaceToIfcTypesLookup.ContainsKey(type)) yield break;
            foreach (var item in _interfaceToIfcTypesLookup[type])
                yield return item;
        }

        public static IEnumerable<Type> TypesImplementing(Type type)
        {
            if (!_interfaceToIfcTypesLookup.ContainsKey(type)) yield break;
            foreach (var item in _interfaceToIfcTypesLookup[type])
                yield return item.Type;
        }

        public static IEnumerable<IfcType> TypesImplementing(string stringType)
        {
            var dictitem = _interfaceToIfcTypesLookup.Keys.FirstOrDefault(intf => String.Equals(intf.Name, stringType, StringComparison.InvariantCultureIgnoreCase));
            if (dictitem == null) yield break;
            foreach (var item in _interfaceToIfcTypesLookup[dictitem])
            {
                yield return item;
            }
        }

        /// <summary>
        /// Returns the IfcType with the specified type
        /// </summary>
        /// <param name="type">The type</param>
        /// <returns>The foud type (or Null if not found)</returns>
        public static IfcType IfcType(Type type)
        {
            if (_typeToIfcTypeLookup.Contains(type))
                return _typeToIfcTypeLookup[type];
            return
                null;
        }

        /// <summary>
        /// returns the IfcType corresponding to the TypeId
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static IfcType IfcType(short typeId)
        {
            return _typeIdToIfcTypeLookup[typeId];
        }

        /// <summary>
        /// returns the ifc type id of the type, if the type is not an ifc entity and excpetion will be thrown
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static short IfcTypeId(Type type)
        {
            return _typeToIfcTypeLookup[type].TypeId;
        }
        /// <summary>
        /// Returns the ifc typeId for the named type
        /// </summary>
        /// <param name="typeName">the name of the type, this is in uppercase</param>
        /// <returns></returns>
        public static short IfcTypeId(string typeName)
        {
            return _typeNameToIfcTypeLookup[typeName].TypeId;
        }

        public static short IfcTypeId(IPersist entity)
        {
            return _typeToIfcTypeLookup[entity.GetType()].TypeId;
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
        public static IfcType IfcType(IPersist entity)
        {
            return _typeToIfcTypeLookup[entity.GetType()];
        }


        /// <summary>
        /// Trys to get the specified Ifc Type with the typeName, if the ifcType does not exist false is returned
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="ifcType"></param>
        /// <returns></returns>
        public static bool TryGetIfcType(string typeName, out IfcType ifcType)
        {
            return _typeNameToIfcTypeLookup.TryGetValue(typeName, out ifcType);
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
            foreach (var item in _typeNameToIfcTypeLookup.Values)
            {
                var l = item.NonAbstractSubTypes;
            }
        }

        
    }
}