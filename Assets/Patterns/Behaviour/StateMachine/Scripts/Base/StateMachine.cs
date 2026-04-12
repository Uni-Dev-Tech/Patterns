using UnityEngine;

namespace Patterns.StateMachine
{
    public class StateMachine
    {
        public IState CurrentState { get; private set; }

        public void SetState(IState newState)
        {
            if (newState == null || CurrentState == newState) return;
            else if (CurrentState != null) CurrentState.Exit();

            CurrentState = newState;
            CurrentState.Enter();
        }
    }
}