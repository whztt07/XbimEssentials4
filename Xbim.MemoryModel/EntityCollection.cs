using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Xbim.Common;

namespace Xbim.MemoryModel
{
    public class EntityCollection<TFactory> : IEntityCollection where TFactory : IEntityFactory, new()
    {
        private readonly IModel _model;
        private readonly Dictionary<Type, List<IPersistEntity>> _internal = new Dictionary<Type, List<IPersistEntity>>();
        private readonly Type[] _types;
        private readonly TFactory _factory;
        private int _instanceCounter = 10000;
        public EntityCollection(IModel model)
        {
            _model = model;
            var mainType = typeof (IPersistEntity);
            _types = mainType.Assembly.GetTypes().Where(t => mainType.IsAssignableFrom(t)).ToArray();
            _factory = new TFactory();
        }

        public IEnumerable<T> Where<T>(Expression<Func<T, bool>> expr) where T : IPersistEntity
        {
            var queryType = typeof(T);
            var condition = expr != null ? expr.Compile() : null;
            var resultTypes = _internal.Keys.Where(t => queryType.IsAssignableFrom(t));
            return
                resultTypes.SelectMany(type => _internal[type], (type, entity) => (T)entity)
                    .Where(result => condition == null || condition(result));
        }

        public IEnumerable<T> OfType<T>() where T : IPersistEntity
        {
            var queryType = typeof(T);
            var resultTypes = _internal.Keys.Where(t => queryType.IsAssignableFrom(t));
            return
                resultTypes.SelectMany(type => _internal[type], (type, entity) => (T) entity);
        }

        public IEnumerable<T> OfType<T>(bool activate) where T : IPersistEntity
        {
            foreach (var entity in OfType<T>())
            {
                _model.Activate(entity, true);
                yield return entity;
            }
        }

        public IEnumerable<IPersistEntity> OfType(string stringType, bool activate)
        {
            var queryType = _types.FirstOrDefault(t => t.Name.ToLower() == stringType.ToLower());
            if(queryType == null) 
                throw new ArgumentException("StringType must be a name of the existing model type");
            
            var resultTypes = _internal.Keys.Where(t => queryType.IsAssignableFrom(t));
            return
                resultTypes.SelectMany(type => _internal[type], (type, entity) => entity);
        }

        public IPersistEntity New(Type t)
        {
            var entity = _factory.New(_model, t, _instanceCounter++, true);
            AddReversible(entity);
            return entity;
        }

        public T New<T>(Action<T> initPropertiesFunc) where T : IInstantiableEntity
        {
            var entity = _factory.New(_model, initPropertiesFunc, _instanceCounter++, true);
            AddReversible(entity);
            return entity;
        }

        public T New<T>() where T : IInstantiableEntity
        {
            var entity = _factory.New<T>(_model, _instanceCounter++, true);
            AddReversible(entity);
            return entity;
        }

        public IPersistEntity this[int label]
        {
            get
            {
                return _internal.Values
                    .Select(list => list.FirstOrDefault(e => e.EntityLabel == label))
                    .FirstOrDefault(entity => entity != null);
            }
        }

        public long Count
        {
            get { return _internal.Values.Aggregate(0, (c, l)=> c + l.Count); }
        }

        public long CountOf<T>() where T : IPersistEntity
        {
            var queryType = typeof(T);
            var resultTypes = _internal.Keys.Where(t => queryType.IsAssignableFrom(t));
            return
                resultTypes.SelectMany(type => _internal[type], (type, entity) => (T)entity).Count();
        }

        private void AddReversible(IPersistEntity entity)
        {
            if (_model.IsTransactional && _model.CurrentTransaction == null) throw new Exception("Operation out of transaction");
            var key = entity.GetType();

            if (_internal.ContainsKey(key))
            {
                Action undo = () => _internal[key].Remove(entity);
                Action doAction = () => _internal[key].Add(entity);
                doAction();

                if (!_model.IsTransactional) return;
                _model.CurrentTransaction.AddReversibleAction(doAction, undo, entity);
            }
            else
            {
                Action doAction = () => _internal.Add(key, new List<IPersistEntity> { entity });
                Action undo = () => _internal.Remove(key);
                doAction();

                if (!_model.IsTransactional) return;
                _model.CurrentTransaction.AddReversibleAction(doAction, undo, entity);
            }

        }

        public IEnumerator<IPersistEntity> GetEnumerator()
        {
            return _internal.SelectMany(kv => kv.Value, (pair, entity) => entity).GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _internal.SelectMany(kv => kv.Value, (pair, entity) => entity).GetEnumerator();
        }
    }
}
