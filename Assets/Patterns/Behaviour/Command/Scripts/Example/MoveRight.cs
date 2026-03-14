using UnityEngine;

namespace Patterns.Command.Example
{
    public class MoveRight : ICommand
    {
        public void Execute()
        {
            Debug.Log("Move right!");
        }

        public void Undo()
        {
            Debug.Log("Move left!");
        }
    }
}