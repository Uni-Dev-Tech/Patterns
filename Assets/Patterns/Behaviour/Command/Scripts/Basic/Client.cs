using UnityEngine;

namespace Patterns.Command.Basic
{
    public class Client : MonoBehaviour
    {
        private ICommand _commandA;
        private ICommand _commandB;

        private void Start()
        {
            _commandA = new CommandA();
            _commandB = new CommandB();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
                _commandA.Execute();

            if (Input.GetKeyDown(KeyCode.W))
                _commandB.Execute();
        }
    }
}