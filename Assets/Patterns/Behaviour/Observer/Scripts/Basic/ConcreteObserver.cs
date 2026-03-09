using UnityEngine;

namespace Patterns.Observer.Basic
{
    public class ConcreteObserver : IObserver
    {
        public void UpdateState(int state)
        {
            Debug.Log($"{this.GetType().Name} observed new state: {state}");
        }
    }
}