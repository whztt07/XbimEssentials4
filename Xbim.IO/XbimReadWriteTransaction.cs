using System.Collections.Generic;
using System.Threading;
using Xbim.Common;

namespace Xbim.IO
{
    /// <summary>
    /// A transaction allowing read and write operations on a model
    /// </summary>
    public class XbimReadWriteTransaction : XbimReadTransaction
    {
        private XbimLazyDBTransaction _readWriteTransaction;
        private int _pulseCount;
        private int _transactionBatchSize;

        /// <summary>
        /// The maximum number of pulse actions before a transaction is automatically commited, default is 100 
        /// </summary>
        public int TransactionBatchSize
        {
            get { return _transactionBatchSize; }
            set { _transactionBatchSize = value; }
        }

        internal XbimReadWriteTransaction(XbimModel theModel, XbimLazyDBTransaction txn)
        {
            Model = theModel;
            _readWriteTransaction = txn;
            InTransaction = true;
            _pulseCount = 0;
            _transactionBatchSize = 100;
        }

        /// <summary>
        /// Increments the pulse count for the transaction, if the pulse count exceed the Transaction batch size the transaction is committed and restarted
        /// </summary>
        /// <returns></returns>
        public int Pulse()
        {
            Interlocked.Increment(ref _pulseCount);
            long remainder = _pulseCount % _transactionBatchSize;
            if (remainder == _transactionBatchSize - 1)
            {
                Commit();
                Begin();
            }
            return _pulseCount;
        }
        public void Commit()
        {
            try
            {
                Model.Flush();
                _readWriteTransaction.Commit();
            }
            finally
            {
                InTransaction = false;
            }
        }

        public void Begin()
        {
            try
            {
                _readWriteTransaction.Begin();
            }
            finally
            {
                InTransaction = true;
            }
        }


        protected override void Dispose(bool disposing)
        {
            try
            {
                if (InTransaction) _readWriteTransaction.Dispose();
            }
            finally
            {
                InTransaction = false;
                base.Dispose(disposing);
            }
        }

        public IEnumerable<IPersistEntity> Modified()
        {
            return Model.Cache.Modified();
        }
    }
}
