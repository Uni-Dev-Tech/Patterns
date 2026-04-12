using UnityEngine;

namespace Patterns.StateMachine
{
    public class AttackState : State
    {
        public AttackState(IStateSwitcher stateSwitcher) : base(stateSwitcher)
        {
        }

        public override void Enter()
        {
            base.Enter();

            Debug.Log("ATTACK STATE ENTER");
            stateSwitcher.SetState(StateType.Idle);
        }
    }
}