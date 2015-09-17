using System;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.MemoryModel
{
    public class Transaction<TFactory> : ITransaction where TFactory : IEntityFactory, new()
    {
        private readonly Model<TFactory> _model;
        private readonly List<Action> _doActions = new List<Action>();
        private readonly List<Action> _undoActions = new List<Action>();
        private readonly HashSet<IPersistEntity> _modified = new HashSet<IPersistEntity>(); 
        private bool _closed;

        public Transaction(Model<TFactory> model, string name)
        {
            Name = name;
            _model = model;
        }

        public Transaction(Model<TFactory> model)
        {
            _model = model;
        }

        public string Name { get; set; }

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

        public void AddReversibleAction(Action doAction, Action undoAction, IPersistEntity entity)
        {
            if (_closed)
                throw new Exception("Transaction is closed already");
            _undoActions.Add(undoAction);
            _doActions.Add(doAction);
            if(_modified.Contains(entity))
                return;
            _modified.Add(entity);
        }

        public IEnumerable<IPersistEntity> Modified { get { return _modified; } }

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

    }
}
