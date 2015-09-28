using System;
using System.Collections.Generic;
using Xbim.Common;

namespace Xbim.IO.Memory
{
    public class Transaction<TFactory> : ITransaction where TFactory : IEntityFactory, new()
    {
        private readonly MemoryModel<TFactory> _model;
        private readonly List<Action> _doActions = new List<Action>();
        private readonly List<Action> _undoActions = new List<Action>();
        private readonly HashSet<IPersistEntity> _modified = new HashSet<IPersistEntity>(); 
        private bool _closed;

        public Transaction(MemoryModel<TFactory> model, string name)
        {
            Name = name;
            _model = model;
        }

        public Transaction(MemoryModel<TFactory> model)
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
                throw new Exception("Transaction is closed already");

            //from back to front
            for (var i = _undoActions.Count -1 ; i == 0 ; i--)
            {
                var undo = _undoActions[i];
                undo();
            }
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
            _doActions.Clear();
            _undoActions.Clear();
        }

    }
}
