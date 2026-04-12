namespace Patterns.StateMachine
{
    public abstract class State : IState
    {
        protected IStateSwitcher stateSwitcher;

        public State(IStateSwitcher stateSwitcher)
        {
            this.stateSwitcher = stateSwitcher;
        }

        public virtual void Enter()
        {

        }

        public virtual void HandleInput()
        {

        }

        public virtual void LogicUpdate()
        {

        }

        public virtual void PhysicsUpdate()
        {

        }

        public virtual void LateUpdate()
        {

        }

        public virtual void Exit()
        {

        }
    }
}