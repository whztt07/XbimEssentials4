// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//		17.09.2015 10:21:14
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using Xbim.Common;

namespace Xbim.Ifc4
{
    public class ItemSet<T> : IItemSet<T>
    {
        private readonly List<T> _set;
        private readonly IModel _model;

		public IPersistEntity OwningEntity { get; private set; }

        protected List<T> Internal
        {
            get { return _set; }
        }


        internal ItemSet(IPersistEntity entity)
        {
            _set = new List<T>();
            _model = entity.Model;
			OwningEntity = entity;
        }

		internal ItemSet(IPersistEntity entity, int count)
        {
            _set = new List<T>(count);
            _model = entity.Model;
			OwningEntity = entity;
        }

        internal ItemSet(IPersistEntity entity, IEnumerable<T> collection)
        {
            _set = new List<T>(collection);
            _model = entity.Model;
			OwningEntity = entity;
        }

		//this is to be only used internaly to add object outside of any transaction or event firing
		//that is typically during parsing operation
		internal void InternalAdd(T value)
		{
			Internal.Add(value);
		}

        #region IItemSet<T> Members
        public T First
        {
            get { return Internal.First(); }
        }

        public T FirstOrDefault()
        {
            return Internal.FirstOrDefault();
        }

        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return Internal.FirstOrDefault(predicate);
        }

        public TF FirstOrDefault<TF>(Func<TF, bool> predicate)
        {
            return OfType<TF>().FirstOrDefault(predicate);
        }

        public IEnumerable<TW> Where<TW>(Func<TW, bool> predicate)
        {
            return OfType<TW>().Where(predicate);
        }

        public IEnumerable<TO> OfType<TO>()
        {
            return Internal.Count == 0 ? Enumerable.Empty<TO>() : Internal.OfType<TO>();
        }
        #endregion

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        [NonSerialized]
        private readonly PropertyChangedEventArgs _countPropChangedEventArgs =
            new PropertyChangedEventArgs("Count");

        private void NotifyCountChanged(int oldValue)
        {
            var propChanged = PropertyChanged;
            if (propChanged != null && oldValue != Internal.Count)
                propChanged(this, _countPropChangedEventArgs);
        }

        #endregion

        #region INotifyCollectionChanged Members

        public event NotifyCollectionChangedEventHandler CollectionChanged;

        #endregion

        #region ICollection<T> Members

        public virtual void Add(T item)
        {
            if(_model.IsTransactional && _model.CurrentTransaction == null)
                throw new Exception("Operation out of transaction");

            var oldCount = Internal.Count;
            Internal.Add(item);

            if (_model.IsTransactional)
            {
                Action undoAction = () => Internal.Remove(item);
                Action doAction = () => Internal.Add(item);
                _model.CurrentTransaction.AddReversibleAction(doAction, undoAction, OwningEntity);
            }

            if (CollectionChanged != null)
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));

            NotifyCountChanged(oldCount);
        }


        public virtual void Clear()
        {
            if (_model.IsTransactional && _model.CurrentTransaction == null)
                throw new Exception("Operation out of transaction");

            var oldCount = Count;
            Internal.Clear();
            
            if (_model.IsTransactional)
            {
                var oldItems = Internal.ToArray();
                Action doAction = () => Internal.Clear();
                Action undoAction = () => Internal.AddRange(oldItems);
                _model.CurrentTransaction.AddReversibleAction(doAction, undoAction, OwningEntity);
            }

            if (CollectionChanged != null)
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));

            NotifyCountChanged(oldCount);
        }

        public bool Contains(T item)
        {
            return Internal.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            Internal.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return Internal.Count; }
        }


        public virtual bool Remove(T item)
        {
            if (_model.IsTransactional && _model.CurrentTransaction == null)
                throw new Exception("Operation out of transaction");

            var oldCount = Internal.Count;
            var removed = Internal.Remove(item);
            if (!removed) return false;

            if (_model.IsTransactional)
            {
                Action doAction = () => Internal.Remove(item);
                Action undoAction = () => Internal.Add(item);
                _model.CurrentTransaction.AddReversibleAction(doAction, undoAction, OwningEntity);
            }

            if (CollectionChanged != null)
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));

            NotifyCountChanged(oldCount);
            return true;
        }

        #endregion

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            return Internal.Count == 0 ? Enumerable.Empty<T>().GetEnumerator() : Internal.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            if (Internal.Count == 0)
                return Enumerable.Empty<T>().GetEnumerator();
            else
                return Internal.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Internal.Count == 0 ? Enumerable.Empty<T>().GetEnumerator() : Internal.GetEnumerator();
        }

        #endregion

        #region ICollection<T> Members

        void ICollection<T>.Add(T item)
        {
            Add(item);
        }

        void ICollection<T>.Clear()
        {
            Clear();
        }

        bool ICollection<T>.Contains(T item)
        {
            return Internal.Contains(item);
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            Internal.CopyTo(array, arrayIndex);
        }

        int ICollection<T>.Count
        {
            get { return Count; }
        }

        bool ICollection<T>.IsReadOnly
        {
            get { return ((IList<T>)Internal).IsReadOnly; }
        }

        bool ICollection<T>.Remove(T item)
        {
            return Remove(item);
        }

        #endregion

        #region ICollection Members

        void ICollection.CopyTo(Array array, int index)
        {
            CopyTo((T[])array, index);
        }

        int ICollection.Count
        {
            get { return Internal.Count; }
        }

        bool ICollection.IsSynchronized
        {
            get { return ((ICollection)Internal).IsSynchronized; }
        }

        object ICollection.SyncRoot
        {
            get { return ((ICollection)Internal).SyncRoot; }
        }

        #endregion

		#region IList<T> members
		public T this[int index]
		{
		    get
		    {
		        return Internal[index];
		    }
		    set
		    {
				if(_model.IsTransactional && _model.CurrentTransaction == null)
				    throw new Exception("Operation out of transaction");

				var oldValue = Internal[index];
		        Internal[index] = value;

				if (_model.IsTransactional)
				{
				    Action doAction = () => Internal[index] = value;
				    Action undoAction = () => Internal[index] = oldValue;
				    _model.CurrentTransaction.AddReversibleAction(doAction, undoAction, OwningEntity);
				}

				if (CollectionChanged != null)
				    CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Replace, value));

		    }
		}

		public int IndexOf(T item)
		{
			return Internal.IndexOf(item);
		}


        public void Insert(int index, T item)
        {
            if (_model.IsTransactional && _model.CurrentTransaction == null)
                throw new Exception("Operation out of transaction");

            var oldCount = Internal.Count;
            Internal.Insert(index, item);

            if (_model.IsTransactional)
            {
                Action undoAction = () => Internal.RemoveAt(index);
                Action doAction = () => Internal.Insert(index, item);
                _model.CurrentTransaction.AddReversibleAction(doAction, undoAction, OwningEntity);
            }

            if (CollectionChanged != null)
                CollectionChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));

            NotifyCountChanged(oldCount);
        }

        public void RemoveAt(int index)
        {
            var toRemove = Internal[index];
            Remove(toRemove);
        }
        #endregion

        #region IList members
        int IList.Add(object value)
        {
            if (!(value is T)) return -1;

            var v = (T) value;
            Add(v);
            return Internal.Count - 1;
        }

        bool IList.Contains(object value)
        {
            return ((IList)Internal).Contains(value);
        }

        int IList.IndexOf(object value)
        {
            return ((IList)Internal).IndexOf(value);
        }

        void IList.Insert(int index, object value)
        {
            Insert(index, (T)value);
        }

        bool IList.IsFixedSize
        {
            get { return false; }
        }

        bool IList.IsReadOnly
        {
            get { return _model.IsTransactional && _model.CurrentTransaction != null; }
        }

        void IList.Remove(object value)
        {
            Remove((T)value);
        }

        object IList.this[int index]
        {
            get
            {
                return this[index];
            }
            set
            {
                this[index] = value == null ? default(T) : (T)value;
            }
        }
        #endregion
    }
}
