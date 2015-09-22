using System;
using System.Collections.ObjectModel;
using Xbim.Common;

namespace Xbim.IO
{
    public class ExpressTypeDictionary : KeyedCollection<Type, ExpressType>
    {
        protected override Type GetKeyForItem(ExpressType item)
        {
            return item.Type;
        }

        public ExpressType this[IPersist ent]
        {
            get { return this[ent.GetType()]; }
        }
    }
}
