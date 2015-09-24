// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		24.09.2015 10:03:36
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.Ifc2x3
{
    public class OptionalItemSet<T>: ItemSet<T>, IOptionalItemSet<T>
    {
        internal OptionalItemSet(IPersistEntity entity) : base(entity)
        {
            Initialized = false;
        }

        internal OptionalItemSet(IPersistEntity entity, int count) : base(entity, count)
        {
            Initialized = false;
        }

        internal OptionalItemSet(IPersistEntity entity, IEnumerable<T> collection) : base(entity, collection)
        {
            Initialized = false;
        }

        public bool Initialized { get; private set; }

        public void Initialize()
        {
            Initialized = true;
        }

        public void Uninitialize()
        {
            Clear();
            Initialized = false;
        }

        public override void Add(T item)
        {
            if (!Initialized) Initialized = true;
            base.Add(item);
        }
    }
}
