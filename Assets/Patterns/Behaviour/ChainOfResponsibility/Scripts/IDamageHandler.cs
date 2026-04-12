namespace Patterns.ChainOfResponsibility
{
    public interface IDamageHandler
    {
        IDamageHandler SetNext(IDamageHandler next);
        void Handle(DamageContext context);
    }
}