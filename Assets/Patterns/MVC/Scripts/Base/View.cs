namespace Patterns.MVC
{
    public abstract class View<T> : IView where T : Model
    {
        protected T Model { get; private set; }

        protected View(T model) { Model = model; }

        public void Initialize() => OnInitialized();
        public void Subscribe() => OnSubscribeEvents();
        public void Unsubscribe() => OnUnsubscribeEvents();

        protected virtual void OnInitialized() { }
        protected abstract void OnSubscribeEvents();
        protected abstract void OnUnsubscribeEvents();
    }
}