namespace Patterns.Observer.Example
{
    public interface IHealthObserver
    {
        void Damaged(int value);
        void Heal(int value);
    }
}