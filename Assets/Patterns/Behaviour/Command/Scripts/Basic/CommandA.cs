using UnityEngine;

namespace Patterns.Command.Basic
{
    public class CommandA : ICommand
    {
        public void Execute()
        {
            Debug.Log("Execute A command action!");
        }
    }
}