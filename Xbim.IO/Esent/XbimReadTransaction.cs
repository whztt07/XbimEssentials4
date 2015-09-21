using System;
using Xbim.Common;

namespace Xbim.IO.Esent
{
    /// <summary>
    /// A transaction allowing read only operations on a model
    /// </summary>
    public class XbimReadTransaction : ITransaction
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
            if (_disposed) return;
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
        public void Dispose()
        {
            Dispose(true);
        }

        string ITransaction.Name
        {
            get { return ""; }
        }

        void ITransaction.Commit()
        {
            throw new Exception("This is a read-only transaction so you can't commit anything.");
        }

        void ITransaction.RollBack()
        {
            throw new Exception("This is a read-only transaction so you can't commit anything.");
        }

        void ITransaction.AddReversibleAction(Action doAction, Action undoAction, IPersistEntity entity)
        {
        }

        System.Collections.Generic.IEnumerable<IPersistEntity> ITransaction.Modified
        {
            get {yield break;}
        }
    }
}
