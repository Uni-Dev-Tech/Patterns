using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Observer.Example
{
    public class HealthPublisher
    {
        private readonly List<IHealthObserver> _observers = new();
        private int _health;

        public int Health => _health;

        public void AddHealth(int value)
        {
            _health = Mathf.Clamp(_health + value, 0, 100);
            HealNotifyObservers();
        }

        public void SubtractHealth(int value)
        {
            _health = Mathf.Clamp(_health - value, 0, 100);
            DamageNotifyObservers();
        }

        public void Attach(IHealthObserver observer) => _observers.Add(observer);
        public void Detach(IHealthObserver observer) => _observers.Remove(observer);

        public void HealNotifyObservers()
            => _observers.ForEach(x => x.Heal(_health));
        public void DamageNotifyObservers()
            => _observers.ForEach(x => x.Damaged(_health));
    }
}