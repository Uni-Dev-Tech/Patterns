using UnityEngine;

namespace Patterns.StateMachine
{
    public class JumpState : State
    {
        public JumpState(IStateSwitcher stateSwitcher) : base(stateSwitcher)
        {
        }

        public override void Enter()
        {
            base.Enter();

            Debug.Log("JUMP STATE ENTER");
            stateSwitcher.SetState(StateType.Idle);
        }
    }
}