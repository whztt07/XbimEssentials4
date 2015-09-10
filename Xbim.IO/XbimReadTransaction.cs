using System;

namespace Xbim.IO
{
    /// <summary>
    /// A transaction allowing read only operations on a model
    /// </summary>
    public class XbimReadTransaction : IDisposable
    {
        /// <summary>
        /// to detect redundant calls
        /// </summary>
        private bool _disposed; 
        /// <summary>
        /// True if we are in a transaction.
        /// </summary>
        protected bool InTransaction;
        protected XbimModel Model;
        private XbimReadOnlyDBTransaction _readTransaction;

        protected XbimReadTransaction()
        {

        }

        internal XbimReadTransaction(XbimModel theModel, XbimReadOnlyDBTransaction txn)
        {
            Model = theModel;
            _readTransaction = txn;
            InTransaction = true;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    try
                    {
                        if (InTransaction) _readTransaction.Dispose();
                    }
                    finally
                    {
                        Model.EndTransaction();
                    }                     
                    
                }
                _disposed = true;
            }
        }
        public void Dispose()
        {
            Dispose(true);
        }
    }
}
