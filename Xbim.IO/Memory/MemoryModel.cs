using System;
using System.IO;
using Xbim.Common;
using Xbim.IO.Step21;

namespace Xbim.IO.Memory
{
    public class MemoryModel<TFactory> : IModel where TFactory: IEntityFactory, new()
    {
        private readonly EntityCollection<TFactory> _instances;
        public MemoryModel()
        {
            _instances = new EntityCollection<TFactory>(this);
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

        public virtual void Open(Stream stream)
        {
            var parser = new XbimP21Parser(stream);
            parser.EntityCreate += (string name, long? label, bool header, out int[] ints) =>
            {
                //allow all attributes to be parsed
                ints = null;

                if (header) 
                    return null;
                if (label == null) 
                    return _instances.Factory.New(name);
                
                var ent = _instances.Factory.New(this, name, (int) label, true);
                _instances.InternalAdd(ent);
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
    }
}
