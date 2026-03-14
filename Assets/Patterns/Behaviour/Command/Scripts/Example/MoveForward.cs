using UnityEngine;

namespace Patterns.Command.Example
{
    public class MoveForward : ICommand
    {
        public void Execute()
        {
            Debug.Log("Move forward!");
        }

        public void Undo()
        {
            Debug.Log("Move backward!");
        }
    }
}