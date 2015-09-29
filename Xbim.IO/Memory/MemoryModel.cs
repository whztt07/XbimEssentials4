using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Xbim.Common;
using Xbim.Common.Step21;
using Xbim.IO.Step21;

namespace Xbim.IO.Memory
{
    public class MemoryModel<TFactory> : IModel where TFactory: IEntityFactory, new()
    {
        private readonly EntityCollection<TFactory> _instances;
        public MemoryModel()
        {
            _instances = new EntityCollection<TFactory>(this);
            Header = new StepFileHeader(StepFileHeader.HeaderCreationMode.InitWithXbimDefaults);
            Header.FileSchema.Schemas.AddRange(_instances.Factory.SchemasIds);
            SchemaModule = typeof (TFactory).Module;
            ModelFactors = new XbimModelFactors(180.0/Math.PI, 0.001, 1e-9);
        }

        public IEntityCollection Instances
        {
            get { return _instances; }
        }

        public int Activate(IPersistEntity owningEntity, bool write)
        {
            return 0;
        }

        /// <summary>
        /// This will delete the entity from model dictionary and also from any references in the model.
        /// Be carefull as this might take a while to check for all occurances of the object. Also make sure 
        /// you don't use this object anymore yourself because it won't get disposed until than.
        /// </summary>
        /// <param name="entity"></param>
        public void Delete(IPersistEntity entity)
        {
            //remove from entity collection
            var removed = _instances.RemoveReversible(entity);
            if (!removed) return;

            var entityType = entity.GetType();
            var entityGenericType = typeof (IEnumerable<>);

            //find all potential references and delete from there
            var types = ExpressMetaData.Types(entity.GetType().Module).Where(t => typeof(IInstantiableEntity).IsAssignableFrom(t.Type));
            foreach (var type in types)
            {
                var toNullify = type.Properties.Values.Where(p => 
                    p.EntityAttribute != null && p.EntityAttribute.Order > 0 &&
                    p.PropertyInfo.PropertyType.IsAssignableFrom(entityType)).ToList();
                var toRemove =
                    type.Properties.Values.Where(p =>
                        p.EntityAttribute != null && p.EntityAttribute.Order > 0 &&
                        p.PropertyInfo.PropertyType.IsGenericType && 
                        p.PropertyInfo.PropertyType.GenericTypeArgumentIsAssignableFrom(entityType)).ToList();
                if (!toNullify.Any() && !toRemove.Any()) continue;

                //get all instances of this type and nullify and remove the entity
                var entitiesToCheck = _instances.OfType(type.Type);
                foreach (var toCheck in entitiesToCheck)
                {
                    //check properties
                    foreach (var pInfo in toNullify.Select(p => p.PropertyInfo))
                    {
                        var pVal = pInfo.GetValue(toCheck);
                        if(pVal == null) continue;
                        //it is enough to compare references
                        if (!ReferenceEquals(pVal, entity)) continue;
                        pInfo.SetValue(toCheck, null);
                    }

                    foreach (var pInfo in toRemove.Select(p => p.PropertyInfo))
                    {
                        var pVal = pInfo.GetValue(toCheck);
                        if (pVal == null) continue;

                        //it might be uninitialized optional item set
                        var optSet = pVal as IOptionalItemSet;
                        if(optSet != null && !optSet.Initialized) continue;

                        //or it is non-optional item set implementind IList
                        var itemSet = pVal as IList;
                        if (itemSet != null )
                        {
                            if (itemSet.Contains(entity))
                                itemSet.Remove(entity);
                            continue;
                        }

                        //fall back operating on common list functions using reflection (this is slow)
                        var contMethod = pInfo.PropertyType.GetMethod("Contains");
                        if (contMethod == null) continue;
                        var contains = (bool)contMethod.Invoke(pVal, new object[] {entity});
                        if(!contains) continue;
                        var removeMethod = pInfo.PropertyType.GetMethod("Remove");
                        if(removeMethod == null) continue;
                        removeMethod.Invoke(pVal, new object[] { entity });
                    }
                }
            }
        }

        public ITransaction BeginTransaction(string name)
        {
            if (CurrentTransaction != null)
                throw new Exception("Transaction is opened already.");

            var txn = new Transaction<TFactory>(this);
            CurrentTransaction = txn;
            return txn;
        }

        public IStepFileHeader Header { get; private set; }

        public virtual bool IsTransactional
        {
            get { return true; }
        }

        /// <summary>
        /// Weak reference allows garbage collector to collect transaction once it goes out of the scope
        /// even if it is still referenced from model. This is important for the cases where the transaction
        /// is both not commited and not rolled back either.
        /// </summary>
        private WeakReference _transactionReference; 

        public ITransaction CurrentTransaction
        {
            get
            {
                if (_transactionReference == null || !_transactionReference.IsAlive)
                    return null;
                return _transactionReference.Target as ITransaction;
            }
            internal set
            {
                if (value == null)
                {
                    _transactionReference = null;
                    return;
                }
                if (_transactionReference == null)
                    _transactionReference = new WeakReference(value);
                else
                    _transactionReference.Target = value;
            } 
        }

        public Module SchemaModule { get; private set; }
        public IModelFactors ModelFactors { get; private set; }
        public void ForEach<TSource>(IEnumerable<TSource> source, Action<TSource> body) where TSource : IPersistEntity
        {
            foreach (var entity in source)
            {
                body(entity);
            }
        }

        public virtual void Open(Stream stream)
        {
            var parser = new XbimP21Parser(stream);
            parser.EntityCreate += (string name, long? label, bool header, out int[] ints) =>
            {
                //allow all attributes to be parsed
                ints = null;

                if (header)
                {
                    switch (name)
                    {
                        case "FILE_DESCRIPTION":
                            return Header.FileDescription;
                        case "FILE_NAME":
                            return Header.FileName;
                        case "FILE_SCHEMA":
                            return Header.FileSchema;
                        default:
                            return null;
                    }
                }
                if (label == null) 
                    return _instances.Factory.New(name);
                
                var ent = _instances.Factory.New(this, name, (int) label, true);
                _instances.InternalAdd(ent);

                //make sure that new added entities will have higher labels to avoid any clashes
                if (label >= _instances.NextLabel)
                    _instances.NextLabel = (int)label + 1;
                return ent;
            };
            parser.Parse();
        }

        public virtual void Open(string file)
        {
            using (var stream = File.OpenRead(file))
            {
                Open(stream);
                stream.Close();
            }
        }

        public virtual void Save(string path)
        {
            using (var file = File.Create(path))
            {
                Save(file);
                file.Close();
            }
        }

        public virtual void Save(Stream stream)
        {
            using (var writer = new StreamWriter(stream))
            {
                Save(writer);
                writer.Close();
            }
        }

        public virtual void Save(TextWriter writer)
        {
            var part21Writer = new Part21FileWriter();
            part21Writer.Write(this, writer, new Dictionary<int, int>());
        }
    }
}
