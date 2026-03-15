using UnityEngine;

namespace Patterns.FactoryMethod
{
    public class ZombieEnemy : MonoBehaviour, IEnemy
    {
        public void Initialize()
        {
            Debug.Log("Zombie initialized");
        }
    }
}