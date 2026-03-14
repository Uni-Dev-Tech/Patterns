using UnityEngine;

namespace Patterns.Command.Example
{
    public class PlayerInput : MonoBehaviour
    {
        private CommandContainer _commandContainer;
        private ICommand _moveForward,
            _moveBackward,
            _moveRight,
            _moveLeft;

        private void Start()
        {
            _commandContainer = new CommandContainer();

            _moveForward = new MoveForward();
            _moveBackward = new MoveBackward();
            _moveLeft = new MoveLeft();
            _moveRight = new MoveRight();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.W)) ExecuteCommand(_moveForward);
            else if (Input.GetKeyDown(KeyCode.S)) ExecuteCommand(_moveBackward);
            else if (Input.GetKeyDown(KeyCode.D)) ExecuteCommand(_moveRight);
            else if (Input.GetKeyDown(KeyCode.A)) ExecuteCommand(_moveLeft);
            else if (Input.GetKeyDown(KeyCode.U)) UndoPrevious();
        }

        private void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _commandContainer.Add(command);
        }

        private void UndoPrevious()
        {
            _commandContainer.UndoLast();
        }
    }
}