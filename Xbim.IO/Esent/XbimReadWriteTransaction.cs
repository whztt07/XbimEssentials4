﻿using System;
using System.Collections.Generic;
using System.Threading;
using Xbim.Common;
using Xbim.Common.Exceptions;

namespace Xbim.IO.Esent
{
    /// <summary>
    /// A transaction allowing read and write operations on a model
    /// </summary>
    public class XbimReadWriteTransaction : XbimReadTransaction, ITransaction
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

        public string Name { get; protected set; }

        internal XbimReadWriteTransaction(EsentModel theModel, XbimLazyDBTransaction txn, string name = null)
        {
            Name = name;
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
                Model.CurrentTransaction = null;
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
                if (InTransaction)
                {
                    ((ITransaction)this).RollBack();
                    _readWriteTransaction.Dispose();
                }
                _undoActions.Clear();
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

        string ITransaction.Name
        {
            get { return Name; }
        }

        void ITransaction.Commit()
        {
            Commit();
        }

        void ITransaction.RollBack()
        {
            try
            {
                foreach (var action in _undoActions)
                {
                    action();
                }
                if (InTransaction) _readWriteTransaction.RollBack();
                InTransaction = false;
                Model.CurrentTransaction = null;
            }
            catch (Exception e)
            {
                throw new XbimException("It wasn't possible to roll back transaction '" + Name + "'. Model is inconsistent now.", e);
            }
        }

        private readonly List<Action> _undoActions = new List<Action>(); 
        
        void ITransaction.AddReversibleAction(Action doAction, Action undoAction, IPersistEntity entity)
        {
            _undoActions.Add(undoAction);
        }

        IEnumerable<IPersistEntity> ITransaction.Modified
        {
            get { return Modified(); }
        }
    }
}
