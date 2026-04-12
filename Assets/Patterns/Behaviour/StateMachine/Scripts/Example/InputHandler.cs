using System;
using UnityEngine;

namespace Patterns.StateMachine
{
    public class InputHandler
    {
        public event Action OnForward;
        public event Action OnBackward;
        public event Action OnRight;
        public event Action OnLeft;
        public event Action OnJump;
        public event Action OnAttack;
        public event Action OnEmptyInput;

        public void UpdateInput()
        {
            if (Input.GetKey(KeyCode.W)) OnForward?.Invoke();
            else if (Input.GetKey(KeyCode.S)) OnBackward?.Invoke();
            else if (Input.GetKey(KeyCode.A)) OnLeft?.Invoke();
            else if (Input.GetKey(KeyCode.D)) OnRight?.Invoke();
            else if (Input.GetKeyDown(KeyCode.Space)) OnJump?.Invoke();
            else if (Input.GetMouseButtonDown(0)) OnAttack?.Invoke();
            else OnEmptyInput?.Invoke();
        }
    }
}