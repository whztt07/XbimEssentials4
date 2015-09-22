using System;
using System.Collections.Generic;
using System.IO;
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
            Header = new StepFileHeader(StepFileHeader.HeaderCreationMode.LeaveEmpty);
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
