namespace Patterns.StateMachine
{
    public abstract class PlayerInputState : State
    {
        protected InputHandler inputHandler;

        public PlayerInputState(IStateSwitcher stateSwitcher, InputHandler inputHandler) : base(stateSwitcher)
        {
            this.inputHandler = inputHandler; ;
        }
    }
}