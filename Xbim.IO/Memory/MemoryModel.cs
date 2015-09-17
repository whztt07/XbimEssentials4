using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using Xbim.Common;
using Xbim.IO.Parser;

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

        public bool IsTransactional
        {
            get { return true; }
        }

        public ITransaction CurrentTransaction
        {
            get; internal set; 
        }

        public void Open(Stream stream)
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
                
                var ent = _instances.Factory.New(this, name, (int)(label ?? 0), true);
                _instances.InternalAdd(ent);
                return ent;
            };
            parser.Parse();
        }

        public void Open(string file)
        {
            using (var stream = File.OpenRead(file))
            {
                Open(stream);
                stream.Close();
            }
        }
    }
}
