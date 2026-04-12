namespace Patterns.ChainOfResponsibility
{
    public abstract class DamageHandler : IDamageHandler
    {
        private IDamageHandler _next;

        public IDamageHandler SetNext(IDamageHandler next)
        {
            _next = next;
            return next;
        }

        public virtual void Handle(DamageContext context)
        {
            _next?.Handle(context);
        }
    }
}