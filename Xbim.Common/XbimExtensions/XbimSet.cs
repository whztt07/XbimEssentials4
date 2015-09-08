﻿#region XbimHeader

// The eXtensible Building Information Modelling (xBIM) Toolkit
// Solution:    XbimComplete
// Project:     Xbim.Ifc
// Filename:    XbimSet.cs
// Published:   01, 2012
// Last Edited: 9:04 AM on 20 12 2011
// (See accompanying copyright.rtf)

#endregion

#region Directives

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using Xbim.XbimExtensions.Transactions.Extensions;
using Xbim.XbimExtensions.Interfaces;
using System.Runtime.CompilerServices;
using Xbim.Common;
using Xbim.Common.XbimExtensions.Interfaces;

#endregion
[assembly: InternalsVisibleTo("Xbim.Ifc2x3, PublicKey=002400000480000094000000060200000024000052534131000400000100010029a3c6da60efcb3ebe48c3ce14a169b5fa08ffbf5f276392ffb2006a9a2d596f5929cf0e68568d14ac7cbe334440ca0b182be7fa6896d2a73036f24bca081b2427a8dec5689a97f3d62547acd5d471ee9f379540f338bbb0ae6a165b44b1ae34405624baa4388404bce6d3e30de128cec379147af363ce9c5845f4f92d405ed0")]

namespace Xbim.XbimExtensions
{
    [IfcPersistedEntityAttribute, Serializable]
    public class XbimSet<T> : ICollection<T>, IEnumerable<T>, ICollection, INotifyCollectionChanged,
                              INotifyPropertyChanged, IExpressEnumerable, IXbimNoNotifyCollection
    {
        private readonly IList<T> _set;

        protected IList<T> m_set
        {
            get { return _set; }
        }

        internal XbimSet(IPersistEntity owner)
        {
            _set = new List<T>();
            _owningEntity = owner;
        }

        internal XbimSet(IPersistEntity owner, IEnumerable<T> collection)
        {
            _set = new List<T>(collection);
            _owningEntity = owner;
        }

        #region INotifyPropertyChanged Members

        [field: NonSerialized]
        private event PropertyChangedEventHandler _propertyChanged;

        [NonSerialized] private static PropertyChangedEventArgs countPropChangedEventArgs =
            new PropertyChangedEventArgs("Count");

        public event PropertyChangedEventHandler PropertyChanged
        {
            add { _propertyChanged += value; }
            remove { _propertyChanged -= value; }
        }

        private void NotifyCountChanged(int oldValue)
        {
            PropertyChangedEventHandler propChanged = _propertyChanged;
            if (propChanged != null && oldValue != m_set.Count)
                propChanged(this, countPropChangedEventArgs);
        }

        #endregion

        #region INotifyCollectionChanged Members

        [field: NonSerialized]
        private event NotifyCollectionChangedEventHandler _collectionChanged;

        public event NotifyCollectionChangedEventHandler CollectionChanged
        {
            add { _collectionChanged += value; }
            remove { _collectionChanged -= value; }
        }

        #endregion

        public T First
        {
            get { return m_set.First(); }
        }

        public T FirstOrDefault()
        {
            return m_set.FirstOrDefault();
        }

        public T FirstOrDefault(Func<T, bool> predicate)
        {
            return m_set.FirstOrDefault(predicate);
        }

        public FT FirstOrDefault<FT>(Func<FT, bool> predicate)
        {
            return OfType<FT>().FirstOrDefault<FT>(predicate);
        }

        public IEnumerable<WT> Where<WT>(Func<WT, bool> predicate)
        {
            return OfType<WT>().Where(predicate);
        }


        public IEnumerable<OT> OfType<OT>()
        {
            if (m_set.Count == 0) return Enumerable.Empty<OT>();
            else return m_set.OfType<OT>();
        }

        #region ICollection<T> Members

        public virtual void Add(T item)
        {
            var oldCount = m_set.Count;
            m_set.Add(item);
            if (_owningEntity.Activated) 
                _owningEntity.Model.Activate(_owningEntity, true);
            var collChanged = _collectionChanged;
            if (collChanged != null)
                collChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Add, item));

            NotifyCountChanged(oldCount);
        }


        public virtual void Clear()
        {
            int oldCount = Count;
            m_set.Clear();
            if (_owningEntity.Activated) _owningEntity.Model.Activate(_owningEntity, true);
            NotifyCollectionChangedEventHandler collChanged = _collectionChanged;
            if (collChanged != null)
                collChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Reset));

            NotifyCountChanged(oldCount);
        }

        public bool Contains(T item)
        {
            return m_set.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            m_set.CopyTo(array, arrayIndex);
        }

        public int Count
        {
            get { return m_set.Count; }
        }


        public virtual bool Remove(T item)
        {
            int oldCount = m_set.Count;
            bool removed = m_set.Remove(item);
            if (removed)
            {
                if (_owningEntity.Activated) _owningEntity.Model.Activate(_owningEntity, true);
                var collChanged = _collectionChanged;
                if (collChanged != null)
                    collChanged(this, new NotifyCollectionChangedEventArgs(NotifyCollectionChangedAction.Remove, item));

                NotifyCountChanged(oldCount);
            }
            return removed;
        }

        #endregion

        #region IEnumerable<T> Members

        public IEnumerator<T> GetEnumerator()
        {
            if (m_set.Count == 0)
                return Enumerable.Empty<T>().GetEnumerator();
            else
                return m_set.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            if (m_set.Count == 0)
                return Enumerable.Empty<T>().GetEnumerator();
            else
                return m_set.GetEnumerator();
        }

        #endregion

        #region IEnumerable Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (m_set.Count == 0)
                return Enumerable.Empty<T>().GetEnumerator();
            else return m_set.GetEnumerator();
        }

        #endregion

        #region ICollection<T> Members

        void ICollection<T>.Add(T item)
        {
            this.Add(item);
        }

        void ICollection<T>.Clear()
        {
            this.Clear();
        }

        bool ICollection<T>.Contains(T item)
        {
            return m_set.Contains(item);
        }

        void ICollection<T>.CopyTo(T[] array, int arrayIndex)
        {
            m_set.CopyTo(array, arrayIndex);
        }

        int ICollection<T>.Count
        {
            get { return this.Count; }
        }

        bool ICollection<T>.IsReadOnly
        {
            get { return (m_set).IsReadOnly; }
        }

        bool ICollection<T>.Remove(T item)
        {
            return this.Remove(item);
        }

        #endregion

        #region ICollection Members

        void ICollection.CopyTo(Array array, int index)
        {
            this.CopyTo((T[]) array, index);
        }

        int ICollection.Count
        {
            get { return m_set.Count; }
        }

        bool ICollection.IsSynchronized
        {
            get { return ((ICollection) m_set).IsSynchronized; }
        }

        object ICollection.SyncRoot
        {
            get { return ((ICollection) m_set).SyncRoot; }
        }

        #endregion


        #region ExpressEnumerable Members

        string IExpressEnumerable.ListType
        {
            get { return "set"; }
        }

        #endregion

      

        private readonly IPersistEntity _owningEntity;

        private IPersistEntity OwningEntity
        {
            get { return _owningEntity; }
        }


        void IExpressEnumerable.Add(object o)
        {
            this.Add((T)o);
        }

        void IXbimNoNotifyCollection.Add(object o)
        {
            m_set.Add((T)o);
        }
    }
}