using System;
using System.Collections.ObjectModel;
using Xbim.Common;

namespace Xbim.IO
{
    public class IfcTypeDictionary : KeyedCollection<Type, IfcType>
    {
        protected override Type GetKeyForItem(IfcType item)
        {
            return item.Type;
        }

        public IfcType this[IPersist ent]
        {
            get { return this[ent.GetType()]; }
        }

        public IfcType this[string ifcTypeName]
        {
            get { return IfcMetaData.IfcType(ifcTypeName); }
        }

        
    }
}
