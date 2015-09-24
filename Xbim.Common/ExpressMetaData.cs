using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace Xbim.Common
{
    public class ExpressMetaProperty
    {
        public PropertyInfo PropertyInfo;
        public EntityAttributeAttribute EntityAttribute;
    }

    /// <summary>
    ///   A collection of IPersistEntity instances, optimised for EXPRESS models
    /// </summary>
    [Serializable]
    public class ExpressMetaData
    {
        /// <summary>
        /// Look up for the if of an entity that returns the ExpresType
        /// </summary>
        private readonly Dictionary<short, ExpressType> _typeIdToExpressTypeLookup;
        /// <summary>
        /// Look up the entity Type and return the ExpressType
        /// </summary>
        private readonly ExpressTypeDictionary _typeToExpressTypeLookup;
        /// <summary>
        /// Look up the name of an entity and return the ExpressType
        /// </summary>
        private readonly Dictionary<string, ExpressType> _typeNameToExpressTypeLookup;
        /// <summary>
        /// Look up the name of an entity and return the ExpressType
        /// </summary>
        private readonly Dictionary<string, ExpressType> _persistNameToExpressTypeLookup;
        /// <summary>
        /// Look up ExpressTypes implementing an interface
        /// </summary>
        private readonly Dictionary<Type, List<ExpressType>> _interfaceToExpressTypesLookup;

        private static readonly Dictionary<Module, ExpressMetaData> Cache = new Dictionary<Module, ExpressMetaData>();

        private static ExpressMetaData GetMetadata(Module module)
        {
            if (Cache.ContainsKey(module))
                return Cache[module];

            var metadata = new ExpressMetaData(module);
            Cache.Add(module, metadata);
            return metadata;
        }

        private ExpressMetaData(Module module)
        {
            var typesToProcess =
                module.GetTypes().Where(
                    t =>
                    typeof(IPersist).IsAssignableFrom(t) && t != typeof(IPersist) && !t.IsEnum && !t.IsAbstract &&
                    t.IsPublic && !typeof(IExpressHeaderType).IsAssignableFrom(t)).ToList();

            _typeIdToExpressTypeLookup = new Dictionary<short, ExpressType>(typesToProcess.Count);
            _typeNameToExpressTypeLookup = new Dictionary<string, ExpressType>(typesToProcess.Count);
            _persistNameToExpressTypeLookup = new Dictionary<string, ExpressType>(typesToProcess.Count);
            _typeToExpressTypeLookup = new ExpressTypeDictionary();
            _interfaceToExpressTypesLookup = new Dictionary<Type, List<ExpressType>>();

            try
            {
                // System.Diagnostics.Debug.Write(typesToProcess.Count());
                foreach (var typeToProcess in typesToProcess)
                {
                    // Debug.WriteLine(typeToProcess.ToString());
                    ExpressType expressTypeToProcess;
                    if (_typeToExpressTypeLookup.Contains(typeToProcess))
                        expressTypeToProcess = _typeToExpressTypeLookup[typeToProcess];
                    else
                    {
                        var isIndexed = typeToProcess.GetCustomAttributes(typeof(IndexedClass), true).Any();
                        expressTypeToProcess = new ExpressType { Type = typeToProcess, IndexedClass = isIndexed };
                    }

                    var typeLookup = typeToProcess.Name.ToUpperInvariant();
                    if (!_typeNameToExpressTypeLookup.ContainsKey(typeLookup))
                        _typeNameToExpressTypeLookup.Add(typeLookup, expressTypeToProcess);

                    if (typeof (IPersistEntity).IsAssignableFrom(typeToProcess))
                    {
                        _persistNameToExpressTypeLookup.Add(expressTypeToProcess.ExpressName, expressTypeToProcess);
                        _typeIdToExpressTypeLookup.Add(expressTypeToProcess.TypeId, expressTypeToProcess);
                    }

                    if (!_typeToExpressTypeLookup.Contains(expressTypeToProcess))
                    {
                        _typeToExpressTypeLookup.Add(expressTypeToProcess);
                        AddParent(expressTypeToProcess);
                        AddProperties(expressTypeToProcess);
                    }

                    // populate the dictionary lookup by interface
                    //
                    foreach (var interfaceFound in typeToProcess.GetInterfaces())
                    {
                        if (!interfaceFound.Namespace.StartsWith("Xbim"))
                            continue;
                        if (!_interfaceToExpressTypesLookup.ContainsKey(interfaceFound))
                        {
                            // add to dictionary
                            _interfaceToExpressTypesLookup.Add(interfaceFound, new List<ExpressType>());
                        }
                        _interfaceToExpressTypesLookup[interfaceFound].Add(expressTypeToProcess);
                    }
                }

                // add the index property to abstract types
                //
                foreach (var type in _typeToExpressTypeLookup.Where(t => t.Type.IsAbstract))
                    type.IndexedClass = type.Type.GetCustomAttributes(typeof(IndexedClass), true).Any();
            }
            catch (Exception e)
            {
                throw new Exception("Error reading Entity Meta Data", e);
            }
        }

        internal static void AddProperties(ExpressType expressType)
        {
            var properties =
                expressType.Type.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy);
            foreach (var propInfo in properties)
            {
                var attributeIdx = -1;
                var attribute =
                    ((EntityAttributeAttribute[])propInfo.GetCustomAttributes(typeof(EntityAttributeAttribute), false)).FirstOrDefault();
                if (attribute != null) //we have an entity property
                {
                    if (attribute.Order > 0)
                    {
                        // SUPPORT: if the code breaks here there's a problem with the order attribut in a class property
                        expressType.Properties.Add(attribute.Order,
                                                    new ExpressMetaProperty { PropertyInfo = propInfo, EntityAttribute = attribute });
                        attributeIdx = attribute.Order;                     
                    }
                    else
                        expressType.Inverses.Add(new ExpressMetaProperty { PropertyInfo = propInfo, EntityAttribute = attribute });
                }
                var isIndexed =
                    propInfo.GetCustomAttributes(typeof(IndexedProperty), false).Any();
                if (isIndexed) //we have an index
                {
                    Debug.Assert(typeof(IPersistEntity).IsAssignableFrom(propInfo.PropertyType)
                        || typeof(IEnumerable<IPersistEntity>).IsAssignableFrom(propInfo.PropertyType)); //only handles to IPersistEntitiess or collecctions of IPersistEntities are indexable
                    expressType.AddIndexedAttribute(propInfo, attributeIdx);
                }
            }
        }


        internal void AddParent(ExpressType child)
        {
            var baseParent = child.Type.BaseType;
            if (baseParent == null || typeof(object) == baseParent || typeof(ValueType) == baseParent)
                return;
            ExpressType expressParent;
            if (!_typeToExpressTypeLookup.Contains(baseParent))
            {
                _typeToExpressTypeLookup.Add(expressParent = new ExpressType { Type = baseParent });
                var typeLookup = baseParent.Name.ToUpper();
                if (!_typeNameToExpressTypeLookup.ContainsKey(typeLookup))
                    _typeNameToExpressTypeLookup.Add(typeLookup, expressParent);
                expressParent.SubTypes.Add(child);
                child.SuperType = expressParent;
                AddParent(expressParent);
                AddProperties(expressParent);
            }
            else
            {
                expressParent = _typeToExpressTypeLookup[baseParent];
                child.SuperType = expressParent;
                if (!expressParent.SubTypes.Contains(child))
                    expressParent.SubTypes.Add(child);
            }
        }

        public static IEnumerable<ExpressType> Types(Module module)
        {
            var metadata = GetMetadata(module);
            return metadata._typeNameToExpressTypeLookup.Values;
        }

        /// <summary>
        /// Returns the ExpressType with the specified name (name of type or express name)
        /// </summary>
        /// <param name="typeName">The name of the type in uppercase</param>
        /// <returns>The foud type (or Null if not found)</returns>
        public static ExpressType ExpressType<T>(string typeName) where T: IEntityFactory
        {
            var module = typeof (T).Module;
            return ExpressType(typeName, module);
        }

        public static ExpressType ExpressType(string typeName, Module module)
        {
            var metadata = GetMetadata(module);

            if (metadata._typeNameToExpressTypeLookup.ContainsKey(typeName))
                return metadata._typeNameToExpressTypeLookup[typeName];
            if (metadata._persistNameToExpressTypeLookup.ContainsKey(typeName))
                return metadata._persistNameToExpressTypeLookup[typeName];
            return null;
        }

        public static IEnumerable<ExpressType> ExpressTypesImplementing(Type type)
        {
            var module = type.Module;
            var metadata = GetMetadata(module);

            if (!metadata._interfaceToExpressTypesLookup.ContainsKey(type)) yield break;
            foreach (var item in metadata._interfaceToExpressTypesLookup[type])
                yield return item;
        }

        public static IEnumerable<Type> TypesImplementing(Type type)
        {
            var module = type.Module;
            var metadata = GetMetadata(module);

            if (!metadata._interfaceToExpressTypesLookup.ContainsKey(type)) yield break;
            foreach (var item in metadata._interfaceToExpressTypesLookup[type])
                yield return item.Type;
        }

        public static IEnumerable<ExpressType> TypesImplementing<T>(string stringType) where T: IEntityFactory
        {
            var module = typeof(T).Module;
            return TypesImplementing(stringType, module);
        }

        public static IEnumerable<ExpressType> TypesImplementing(string stringType, Module module)
        {
            var metadata = GetMetadata(module);

            var dictitem = metadata._interfaceToExpressTypesLookup.Keys.FirstOrDefault(intf => string.Equals(intf.Name, stringType, StringComparison.InvariantCultureIgnoreCase));
            if (dictitem == null) yield break;
            foreach (var item in metadata._interfaceToExpressTypesLookup[dictitem])
            {
                yield return item;
            }
        }

        /// <summary>
        /// Returns the ExpressType with the specified type
        /// </summary>
        /// <param name="type">The type</param>
        /// <returns>The foud type (or Null if not found)</returns>
        public static ExpressType ExpressType(Type type)
        {
            var module = type.Module;
            var metadata = GetMetadata(module);

            return metadata._typeToExpressTypeLookup.Contains(type) ? 
                metadata._typeToExpressTypeLookup[type] : 
                null;
        }

        /// <summary>
        /// returns the ExpressType corresponding to the TypeId
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static ExpressType ExpressType<T>(short typeId) where T: IEntityFactory
        {
            var module = typeof(T).Module;
            return ExpressType(typeId, module);
        }

        public static ExpressType ExpressType(short typeId, Module module)
        {
            var metadata = GetMetadata(module);

            return metadata._typeIdToExpressTypeLookup[typeId];
        }

        /// <summary>
        /// returns the express type id of the type, if the type is not an entity and excpetion will be thrown
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static short ExpressTypeId(Type type)
        {
            var module = type.Module;
            var metadata = GetMetadata(module);

            return metadata._typeToExpressTypeLookup[type].TypeId;
        }
        /// <summary>
        /// Returns the typeId for the named type
        /// </summary>
        /// <param name="typeName">the name of the type, this is in uppercase</param>
        /// <returns></returns>
        public static short ExpressTypeId<T>(string typeName) where T:IEntityFactory
        {
            var module = typeof(T).Module;
            return ExpressTypeId(typeName, module);
        }

        public static short ExpressTypeId(string typeName, Module module)
        {
            var metadata = GetMetadata(module);
            return metadata._typeNameToExpressTypeLookup.ContainsKey(typeName) ? 
                metadata._typeNameToExpressTypeLookup[typeName].TypeId : 
                metadata._persistNameToExpressTypeLookup[typeName].TypeId;
        }

        public static short ExpressTypeId(IPersist entity)
        {
            var module = entity.GetType().Module;
            var metadata = GetMetadata(module);

            return metadata._typeToExpressTypeLookup[entity.GetType()].TypeId;
        }

        /// <summary>
        /// Returns the Type of the Entity with typeId
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public static Type GetType<T>(short typeId) where T : IEntityFactory
        {
            return ExpressType<T>(typeId).Type;
        }

        public static Type GetType(short typeId, Module module)
        {
            return ExpressType(typeId, module).Type;
        }

        /// <summary>
        /// Returns the ExpressType of the specified entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static ExpressType ExpressType(IPersist entity)
        {
            var module = entity.GetType().Module;
            var metadata = GetMetadata(module);

            return metadata._typeToExpressTypeLookup[entity.GetType()];
        }


        /// <summary>
        /// Trys to get the specified Type with the typeName, if the ExpressType does not exist false is returned
        /// </summary>
        /// <param name="typeName"></param>
        /// <param name="expressType"></param>
        /// <returns></returns>
        public static bool TryGetExpressType<T>(string typeName, out ExpressType expressType) where T: IEntityFactory
        {
            var module = typeof(T).Module;
            return TryGetExpressType(typeName, out expressType, module);
        }

        public static bool TryGetExpressType(string typeName, out ExpressType expressType, Module module)
        {
            var metadata = GetMetadata(module);
            if (metadata._typeNameToExpressTypeLookup.TryGetValue(typeName, out expressType))
                return true;
            return metadata._persistNameToExpressTypeLookup.TryGetValue(typeName, out expressType);
        }

        /// <summary>
        /// Returns true if the named entities attribute is indexed
        /// </summary>
        /// <param name="entityTypeName">the name of the Entity</param>
        /// <param name="attributeIndex">the index offset of the attribute to check, nb this is a 1 based index</param>
        /// <returns></returns>
        public static bool IsIndexedEntityAttribute<T>(string entityTypeName, int attributeIndex) where T : IEntityFactory
        {
            var type = ExpressType<T>(entityTypeName);
            return type.IsIndexedAttribute(attributeIndex);
        }

        public static bool IsIndexedEntityAttribute(string entityTypeName, int attributeIndex, Module module)
        {
            var type = ExpressType(entityTypeName, module);
            return type.IsIndexedAttribute(attributeIndex);
        }

        public void Load()
        {
            foreach (var l in _typeNameToExpressTypeLookup.Values.Select(item => item.NonAbstractSubTypes))
            {
            }
        }

    }
}