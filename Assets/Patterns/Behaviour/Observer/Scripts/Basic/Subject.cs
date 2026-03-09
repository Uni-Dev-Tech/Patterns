using System.Collections.Generic;

namespace Patterns.Observer.Basic
{
    public class Subject
    {
        private readonly List<IObserver> _observers = new();
        private int _state;

        public int State
        {
            get => _state;
            set
            {
                _state = value;
                NotifyObservers();
            }
        }

        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void NotifyObservers()
            => _observers.ForEach(x => x.UpdateState(_state));
    }
}