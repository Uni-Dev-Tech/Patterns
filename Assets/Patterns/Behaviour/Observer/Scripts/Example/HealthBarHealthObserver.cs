using UnityEngine;

namespace Patterns.Observer.Example
{
    public class HealthBarHealthObserver : IHealthObserver
    {
        public void Damaged(int value)
        {
            Debug.Log("Update progress bar!");
        }

        public void Heal(int value)
        {
            Debug.Log("Update progress bar!");
        }
    }
}