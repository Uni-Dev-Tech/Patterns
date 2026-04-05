using System;
using UnityEngine;

namespace Patterns.MVC.Example
{
    public class EnemyModel : Model
    {
        private int _maxHealth;
        private int _health;

        public event Action<int> OnHeal;
        public event Action<int> OnDamaged;
        public event Action<int, int> OnHealthUpdated;

        public EnemyModel(int maxHealth)
        {
            _maxHealth = maxHealth;
            _health = maxHealth;
        }

        public void ApplyHeal(int value)
        {
            _health = Mathf.Clamp(_health + value, 0, _maxHealth);
            OnHeal?.Invoke(value);
            OnHealthUpdated?.Invoke(_health, _maxHealth);

            Debug.Log($"Current health - {_health}");
        }

        public void ApplyDamage(int value)
        {
            _health = Mathf.Clamp(_health - value, 0, _maxHealth);
            OnDamaged?.Invoke(value);
            OnHealthUpdated?.Invoke(_health, _maxHealth);

            Debug.Log($"Current health - {_health}");
        }
    }
}