namespace Patterns.StateMachine
{
    public interface IState
    {
        void Enter();
        void HandleInput();
        void LogicUpdate();
        void PhysicsUpdate();
        void LateUpdate();
        void Exit();
    }
}