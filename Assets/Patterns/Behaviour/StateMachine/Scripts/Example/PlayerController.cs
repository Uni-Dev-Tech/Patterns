using System.Collections.Generic;

namespace Patterns.StateMachine
{
    public class PlayerController : BaseController
    {
        protected override void Initialize()
        {
            base.stateMachine = new StateMachine();

            var inputHandler = new InputHandler();

            var idle = new IdleState(this, inputHandler);
            var motion = new MotionState(this, inputHandler);
            var jump = new JumpState(this);
            var attack = new AttackState(this);

            base.states = new Dictionary<StateType, IState>();
            states.Add(StateType.Idle, idle);
            states.Add(StateType.Motion, motion);
            states.Add(StateType.Jump, jump);
            states.Add(StateType.Attack, attack);

            stateMachine.SetState(idle);
        }
    }
}