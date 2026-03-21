using UnityEngine;

namespace Patterns.EventBus.Example
{
    public class PlayerStatisticSystem : MonoBehaviour
    {
        [SerializeField] private int _enemyKilledCount;
        [SerializeField] private float _playerMaxDamage;
        [SerializeField] private float _survivedTime;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                EventBus<OnPlayerDeath>.CallEvent(new(_enemyKilledCount, _playerMaxDamage, _survivedTime));
            }
        }
    }
}