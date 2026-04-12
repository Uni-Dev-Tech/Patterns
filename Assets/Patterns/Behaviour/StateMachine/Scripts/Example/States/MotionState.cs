using UnityEngine;

namespace Patterns.StateMachine
{
    public class MotionState : PlayerInputState
    {
        public MotionState(IStateSwitcher stateSwitcher, InputHandler inputHandler) : base(stateSwitcher, inputHandler)
        {
        }

        public override void Enter()
        {
            base.Enter();

            inputHandler.OnForward += OnForward;
            inputHandler.OnBackward += OnBackward;
            inputHandler.OnRight += OnRight;
            inputHandler.OnLeft += OnLeft;
            inputHandler.OnJump += JumpStateTransition;
            inputHandler.OnEmptyInput += IdleStateTransition;

            Debug.Log("MOTION STATE ENTER");
        }

        public override void HandleInput()
        {
            base.HandleInput();

            inputHandler.UpdateInput();
        }

        public override void Exit()
        {
            base.Exit();

            inputHandler.OnForward -= OnForward;
            inputHandler.OnBackward -= OnBackward;
            inputHandler.OnRight -= OnRight;
            inputHandler.OnLeft -= OnLeft;
            inputHandler.OnJump -= JumpStateTransition;
            inputHandler.OnEmptyInput -= IdleStateTransition;
        }

        private void OnForward() => Debug.Log("MOVE FORWARD");
        private void OnBackward() => Debug.Log("MOVE BACKWARD");
        private void OnRight() => Debug.Log("MOVE RIGHT");
        private void OnLeft() => Debug.Log("MOVE LEFT");

        private void JumpStateTransition() => stateSwitcher.SetState(StateType.Jump);
        private void IdleStateTransition() => stateSwitcher.SetState(StateType.Idle);
    }
}