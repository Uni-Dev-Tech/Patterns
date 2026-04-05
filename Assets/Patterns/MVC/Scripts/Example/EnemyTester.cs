using UnityEngine;

namespace Patterns.MVC.Example
{
    public class EnemyTester : MonoBehaviour
    {
        [SerializeField] private EnemyController _enemy;

        private const int _healValue = 5;
        private const int _damageValue = 5;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q)) _enemy.Heal(_healValue);
            else if (Input.GetKeyDown(KeyCode.W)) _enemy.Damaged(_damageValue);
        }
    }
}