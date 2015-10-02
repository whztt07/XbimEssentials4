using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Xbim.Common.Metadata
{
    public class ExpressType
    {
        private Type _type;
        public short TypeId;
        public string ExpressName;
        public SortedList<int, ExpressMetaProperty> Properties = new SortedList<int, ExpressMetaProperty>();
        public List<ExpressMetaProperty> Inverses = new List<ExpressMetaProperty>();
        public ExpressType SuperType;
        public List<ExpressType> SubTypes = new List<ExpressType>();
        private List<Type> _nonAbstractSubTypes;
        private List<ExpressMetaProperty> _expressEnumerableProperties;
        internal bool IndexedClass;

        public Type Type
        {
            get { return _type; }
            set{
                _type = value;
                var entNameAttr = Type.GetCustomAttributes(typeof(ExpressTypeAttribute), false).FirstOrDefault();
                if (entNameAttr == null)
#if DEBUG
                    throw new Exception("Express Type is not defined for " + Type.Name);
#else
                    return -1;
#endif
                TypeId =  (short)((ExpressTypeAttribute)entNameAttr).EntityTypeId;
                ExpressName = ((ExpressTypeAttribute)entNameAttr).Name;
            }
        }
           

        public List<ExpressMetaProperty> ExpressEnumerableProperties
        {
            get
            {
                if (_expressEnumerableProperties == null)
                {
                    _expressEnumerableProperties = new List<ExpressMetaProperty>();
                    foreach (var prop in Properties.Values)
                    {
                        if (typeof(IExpressEnumerable).IsAssignableFrom(prop.PropertyInfo.PropertyType))
                            _expressEnumerableProperties.Add(prop);
                    }
                }
                return _expressEnumerableProperties;
            }
        }

        public override string ToString()
        {
            return Type.Name;
        }



        public IList<Type> NonAbstractSubTypes
        {
            get
            {
                lock (this)
                {
                    if (_nonAbstractSubTypes == null)
                    {
                        _nonAbstractSubTypes = new List<Type>();
                        AddNonAbstractTypes(this, _nonAbstractSubTypes);
                    }
                    return _nonAbstractSubTypes;
                }
               
            }
        }
        /// <summary>
        /// If the type has indexed attributes, this returns a set of unique values for the specified IPersistEntity
        /// </summary>
        /// <param name="ent"></param>
        /// <returns></returns>
        internal IEnumerable<int> GetIndexedValues(IPersistEntity ent)
        {
            if (IndexedProperties == null)
                return Enumerable.Empty<int>();
            var keys = new HashSet<int>();
            foreach (var prop in IndexedProperties)
            {
                var o = prop.GetValue(ent, null);
                var entity = o as IPersistEntity;
                if (entity != null)
                {
                    var h = entity.EntityLabel;
                    keys.Add(h); //normally there are only one or two keys so don't worry about performance of contains on a list
                }
                else if (o is IExpressEnumerable)
                {
                    foreach (var obj in (IExpressEnumerable)o)
                    {
                        var h =((IPersistEntity)obj).EntityLabel;
                        keys.Add(h); //normally there are only one or two keys so don't worry about performance of contains on a list
                    }                    
                }
            }
            return keys;
        }

        internal List<PropertyInfo> IndexedProperties { get; private set; }

        internal List<int> IndexedValues { get; private set; }

        private static void AddNonAbstractTypes(ExpressType expressType, List<Type> nonAbstractTypes)
        {
            if (!expressType.Type.IsAbstract) //this is a concrete type so add it
                nonAbstractTypes.Add(expressType.Type);
            foreach (var subType in expressType.SubTypes)
                AddNonAbstractTypes(subType, nonAbstractTypes);
        }


        /// <summary>
        /// returns true if the attribute is indexed
        /// </summary>
        /// <param name="attributeIndex"></param>
        /// <returns></returns>
        public bool IsIndexedAttribute(int attributeIndex)
        {
            return IndexedValues != null && IndexedValues.Contains(attributeIndex);
        }

        internal void AddIndexedAttribute(PropertyInfo pInfo, int attributeIdx)
        {
            if (IndexedProperties == null) IndexedProperties = new List<PropertyInfo>();
            if (IndexedValues == null) IndexedValues = new List<int>();
            IndexedProperties.Add(pInfo);
            IndexedValues.Add(attributeIdx);
            IndexedClass = true; //if it has keys it must be an indexed class
        }
        /// <summary>
        /// Returns true if the type has an indexed attribute
        /// </summary>
        /// <returns></returns>
        public bool HasIndexedAttribute
        {
            get
            {
                return IndexedValues != null && IndexedValues.Count > 0;
            }
        }

        public string Name 
        {
            get
            {
                return Type.Name; 
            }
        }
    }

}
