using UnityEngine;

namespace Patterns.EventBus.Example
{
    public class AchievementSystem : MonoBehaviour
    {
        private void OnEnable()
        {
            EventBus<OnPlayerDeath>.AddListener(OnPlayerDeath);
        }

        private void OnDisable()
        {
            EventBus<OnPlayerDeath>.RemoveListener(OnPlayerDeath);
        }

        private void OnPlayerDeath(OnPlayerDeath action)
        {
            Debug.Log($"AchievementSystem got event and parametrs:" +
                $" enemy killed count - {action.EnemyKilledCount} and" +
                $" max player damage - {action.PlayerMaxDamage} and" +
                $" survived time - {action.SurvivedTime}");
        }
    }
}