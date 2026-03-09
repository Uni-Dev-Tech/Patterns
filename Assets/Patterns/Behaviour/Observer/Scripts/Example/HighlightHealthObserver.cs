using UnityEngine;

namespace Patterns.Observer.Example
{
    public class HighlightHealthObserver : IHealthObserver
    {
        public void Damaged(int value)
        {
            Debug.Log("Highlight red color!");
        }

        public void Heal(int value)
        {
            Debug.Log("Highlight green color!");
        }
    }
}