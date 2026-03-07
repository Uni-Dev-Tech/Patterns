namespace Patterns.Strategy.Basic
{
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy) => _strategy = strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ApplyStrategy()
        {
            _strategy?.Execute();
        }
    }
}