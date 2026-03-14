using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Command.Example
{
    public class CommandContainer
    {
        private Stack<ICommand> _commandHistory;

        public CommandContainer()
        {
            _commandHistory = new();
        }

        public void Add(ICommand command) => _commandHistory.Push(command);

        public void UndoLast()
        {
            if (_commandHistory.Count == 0)
            {
                Debug.Log("There is no command left!");
                return;
            }

            var last = _commandHistory.Pop();
            last.Undo();
        }
    }
}