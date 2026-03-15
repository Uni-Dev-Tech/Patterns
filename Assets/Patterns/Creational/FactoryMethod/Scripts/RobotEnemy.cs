using UnityEngine;

namespace Patterns.FactoryMethod
{
    public class RobotEnemy : MonoBehaviour, IEnemy
    {
        public void Initialize()
        {
            Debug.Log("Robot initialized");
        }
    }
}