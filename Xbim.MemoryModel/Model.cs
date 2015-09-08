using System;
using Xbim.Common;

namespace Xbim.MemoryModel
{
    public class Model<TFactory> : IModel where TFactory: IEntityFactory, new()
    {

        public Model()
        {
            Instances = new EntityCollection<TFactory>(this);
        }

        public IEntityCollection Instances
        {
            get; private set;
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
    }
}
