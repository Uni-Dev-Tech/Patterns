using UnityEngine;

namespace Patterns.Command.Example
{
    public class MoveLeft : ICommand
    {
        public void Execute()
        {
            Debug.Log("Move left!");
        }

        public void Undo()
        {
            Debug.Log("Move right!");
        }
    }
}