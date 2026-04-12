using UnityEngine;
using System.Collections.Generic;

namespace Patterns.StateMachine
{
    public abstract class BaseController : MonoBehaviour, IStateSwitcher
    {
        protected StateMachine stateMachine;
        protected Dictionary<StateType, IState> states;

        private void Awake()
        {
            Initialize();
        }

        private void Update()
        {
            stateMachine?.CurrentState?.HandleInput();
            stateMachine?.CurrentState?.LogicUpdate();
        }

        private void FixedUpdate()
        {
            stateMachine?.CurrentState?.PhysicsUpdate();
        }

        private void LateUpdate()
        {
            stateMachine?.CurrentState?.LateUpdate();
        }

        protected abstract void Initialize();

        public void SetState(StateType stateType)
        {
            if (!states.TryGetValue(stateType, out var state)) return;
            stateMachine.SetState(state);
        }
    }
}