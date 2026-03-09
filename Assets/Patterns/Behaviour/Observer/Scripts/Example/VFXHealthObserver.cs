using UnityEngine;

namespace Patterns.Observer.Example
{
    public class VFXHealthObserver : IHealthObserver
    {
        public void Damaged(int value)
        {
            Debug.Log("Play damage particles!");
        }

        public void Heal(int value)
        {
            Debug.Log("Play heal particles!");
        }
    }
}