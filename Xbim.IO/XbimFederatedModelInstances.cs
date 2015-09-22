using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Linq.Expressions;
using Xbim.Common;
using Xbim.IO.Esent;

namespace Xbim.IO
{

    internal class XbimFederatedInstancesEntityEnumerator : IEnumerator<IPersistEntity>
    {
        private readonly List<XbimModel> _models;
        int _currentModelIndex;
        private PersistedEntityInstanceCache _cache;
        private XbimEntityCursor _cursor;
        private int _currentEntityLabel;

        public XbimFederatedInstancesEntityEnumerator(IEnumerable<XbimModel> models)
        {
            _models = models.ToList();
            Reset();
        }
        public IPersistEntity Current
        {
            get { return _cache.GetInstance(_currentEntityLabel); }
        }


        public void Reset()
        {
            _currentEntityLabel = 0;
            _currentModelIndex = 0;
            var first = _models.FirstOrDefault();
            if (first != null)
            {
                _cache = first.Cache;
                _cursor = _cache.GetEntityTable(); 
                _cursor.MoveBeforeFirst();
            }
            
        }

        object IEnumerator.Current
        {
            get { return _cache.GetInstance(_currentEntityLabel); }
        }

        bool IEnumerator.MoveNext()
        {
            int label;
            if (_cursor.TryMoveNextLabel(out label))
            {
                _currentEntityLabel = label;
                return true;
            }
            else if (_currentModelIndex < _models.Count-1) //we have more models to process
            {
                _currentModelIndex++; //go to next model
                _cache.FreeTable(_cursor);
                _cache = _models[_currentModelIndex].Cache;
                _cursor = _cache.GetEntityTable();
                _cursor.MoveBeforeFirst();
                if (_cursor.TryMoveNextLabel(out label))
                {
                    _currentEntityLabel = label;
                    return true;
                }
            }
            return false;
        }


        public void Dispose()
        {
            _cache.FreeTable(_cursor);
        }
    }
    public class XbimFederatedModelInstances : IEntityCollection
    {
        readonly XbimModel _model;

        public IEnumerable<IPersistEntity> OfType(string stringType, bool activate)
        {
            
            foreach (var instance in _model.InstancesLocal.OfType(stringType, activate))
                yield return instance;
            foreach (var refModel in _model.ReferencedModels)
                foreach (var instance in refModel.Model.Instances.OfType(stringType, activate))
                    yield return instance;
            
            //long[] l = new long[] { -1, 2 };
            //foreach (var item in l)
            //{
            //    yield return item;    
            //}
        }

        public XbimFederatedModelInstances(XbimModel model)
        {
            _model = model;
        }
        public IEnumerable<T> Where<T>(Expression<Func<T, bool>> expr) where T : IPersistEntity
        {
            foreach (var instance in _model.InstancesLocal.Where(expr))
                yield return instance;
            foreach (var refModel in _model.ReferencedModels)
                foreach (var instance in refModel.Model.Instances.Where(expr))
                    yield return instance;
        }

        public T FirstOrDefault<T>() where T : IPersistEntity
        {
            return OfType<T>().FirstOrDefault();
        }

        public T FirstOrDefault<T>(Expression<Func<T, bool>> expr) where T : IPersistEntity
        {
            return Where(expr).FirstOrDefault();
        }

        public IEnumerable<T> OfType<T>() where T : IPersistEntity
        {
            foreach (var instance in _model.InstancesLocal.OfType<T>())
                yield return instance;
            foreach (var refModel in _model.ReferencedModels)
                foreach (var instance in refModel.Model.Instances.OfType<T>())
                    yield return instance;
        }

        public IEnumerable<T> OfType<T>(bool activate) where T : IPersistEntity
        {
            foreach (var instance in _model.InstancesLocal.OfType<T>(activate))
                yield return instance;
            foreach (var refModel in _model.ReferencedModels)
                foreach (var instance in refModel.Model.Instances.OfType<T>(activate))
                    yield return instance;
        }

        public IPersistEntity New(Type t)
        {
            return _model.InstancesLocal.New(t);
        }

        public T New<T>(Action<T> initPropertiesFunc) where T : IInstantiableEntity
        {
            return _model.InstancesLocal.New(initPropertiesFunc);
        }

        public T New<T>() where T : IInstantiableEntity
        {
            return _model.InstancesLocal.New<T>();
        }


        /// <summary>
        /// returns the local instance with the given label
        /// </summary>
        /// <param name="label"></param>
        /// <returns></returns>
        public IPersistEntity this[int label]
        {
            get { return _model.InstancesLocal[label]; }
        }
        /// <summary>
        /// Returns the instance that corresponds to this handle
        /// </summary>
        /// <param name="handle"></param>
        /// <returns></returns>
        public IPersistEntity this[XbimInstanceHandle handle]
        {
            get { return handle.GetEntity(); }
        }

        public long Count
        {
            get
            {
                return _model.InstancesLocal.Count + _model.ReferencedModels.Sum(refModel => refModel.Model.Instances.Count);
            }
        }

        public long CountOf<T>() where T : IPersistEntity
        {
            return _model.InstancesLocal.CountOf<T>() + _model.ReferencedModels.Sum(refModel => refModel.Model.Instances.CountOf<T>());
        }

        /// <summary>
        /// returns the geometry from the local instances
        /// Does not access federated model geometry
        /// </summary>
        /// <param name="geometryLabel"></param>
        /// <returns></returns>
        public IPersistEntity GetFromGeometryLabel(int geometryLabel)
        {
            var filledGeomData = _model.Cache.GetGeometryHandle(geometryLabel);
            return _model.Cache.GetInstance(filledGeomData.ProductLabel, true, true);
        }

       

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new XbimFederatedInstancesEntityEnumerator(_model.AllModels);
        }

        IEnumerator<IPersistEntity> IEnumerable<IPersistEntity>.GetEnumerator()
        {
            return new XbimFederatedInstancesEntityEnumerator(_model.AllModels);
        }
    }
}
