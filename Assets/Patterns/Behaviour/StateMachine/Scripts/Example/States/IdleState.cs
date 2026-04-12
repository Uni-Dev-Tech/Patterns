using UnityEngine;

namespace Patterns.StateMachine
{
    public class IdleState : PlayerInputState
    {
        public IdleState(IStateSwitcher stateSwitcher, InputHandler inputHandler)
            : base(stateSwitcher, inputHandler)
        {
        }

        public override void Enter()
        {
            base.Enter();

            inputHandler.OnForward += MotionStateTransition;
            inputHandler.OnBackward += MotionStateTransition;
            inputHandler.OnLeft += MotionStateTransition;
            inputHandler.OnRight += MotionStateTransition;
            inputHandler.OnJump += JumpStateTransition;
            inputHandler.OnAttack += AttackStateTransition;

            Debug.Log("IDLE STATE ENTER");
        }

        public override void HandleInput()
        {
            base.HandleInput();

            inputHandler.UpdateInput();
        }

        public override void Exit()
        {
            base.Exit();

            inputHandler.OnForward -= MotionStateTransition;
            inputHandler.OnBackward -= MotionStateTransition;
            inputHandler.OnLeft -= MotionStateTransition;
            inputHandler.OnRight -= MotionStateTransition;
            inputHandler.OnJump -= JumpStateTransition;
            inputHandler.OnAttack -= AttackStateTransition;
        }

        private void MotionStateTransition() => stateSwitcher.SetState(StateType.Motion);
        private void JumpStateTransition() => stateSwitcher.SetState(StateType.Jump);
        private void AttackStateTransition() => stateSwitcher.SetState(StateType.Attack);
    }
}