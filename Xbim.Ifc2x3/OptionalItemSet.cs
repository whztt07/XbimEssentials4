// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		22.09.2015 02:32:01
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

        public override bool Equals(object obj)
        {
            if (obj == null && !Initialized)
                return true;

            var second = obj as OptionalItemSet<T>;
            return second != null && ReferenceEquals(this, obj);
        }

        public static bool operator ==(OptionalItemSet<T> a, OptionalItemSet<T> b)
        {
            if (ReferenceEquals(a, b)) return true;

            //if the list is not initialized, pretend to be . Value has to be boxed so that it is not a recursive call.
            if ((a as object) == null && !b.Initialized)
                return true;
            if ((b as object) == null && !a.Initialized)
                return true;

            return false;
        }

        public static bool operator !=(OptionalItemSet<T> a, OptionalItemSet<T> b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return Internal.GetHashCode();
        }
    }
}
