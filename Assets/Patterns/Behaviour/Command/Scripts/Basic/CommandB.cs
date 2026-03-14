using UnityEngine;

namespace Patterns.Command.Basic
{
    public class CommandB : ICommand
    {
        public void Execute()
        {
            Debug.Log("Execute B command action!");
        }
    }
}