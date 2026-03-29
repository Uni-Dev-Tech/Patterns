using UnityEngine;

namespace Patterns.Decorator
{
    public class BasicEnemy : IEnemy
    {
        public void Attack()
        {
            Debug.Log("Basic attack!");
        }
    }
}