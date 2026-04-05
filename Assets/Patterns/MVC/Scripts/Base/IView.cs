namespace Patterns.MVC
{
    public interface IView
    {
        void Initialize();
        void Subscribe();
        void Unsubscribe();
    }
}