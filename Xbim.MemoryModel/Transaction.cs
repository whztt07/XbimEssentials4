using System;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.MemoryModel
{
    public class Transaction<TFactory> : ITransaction where TFactory : IEntityFactory, new()
    {
        private readonly Model<TFactory> _model;
        private readonly List<Action> _undoActions = new List<Action>();
        private bool _closed;

        public Transaction(Model<TFactory> model)
        {
            _model = model;
        }

        public void Commit()
        {
            if (_closed)
                throw new Exception("Transaction closed already");

            Finish();
        }

        public void RollBack()
        {
            if (_closed)
                throw new Exception("Transaction closed already");

            foreach (var action in _undoActions)
                action();
            Finish();
        }

        private void Finish()
        {
            if (_closed)
                throw new Exception("Transaction closed already"); 
            
            _undoActions.Clear();
            _model.CurrentTransaction = null;
            _closed = true;
        }

        public void Dispose()
        {
            if(!_closed)
                RollBack();
        }


        public void AddReversibleAction(Action action)
        {
            if(_closed)
                throw new Exception("Transaction is closed already");
            _undoActions.Add(action);
        }
    }
}
