using UnityEngine;

namespace Patterns.Command.Example
{
    public class MoveBackward : ICommand
    {
        public void Execute()
        {
            Debug.Log("Move backward!");
        }

        public void Undo()
        {
            Debug.Log("Move forward!");
        }
    }
}