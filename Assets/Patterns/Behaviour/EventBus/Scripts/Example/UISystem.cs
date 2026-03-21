using UnityEngine;

namespace Patterns.EventBus.Example
{
    public class UISystem : MonoBehaviour
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
            Debug.Log($"UISystem got event and parametr:" +
                $" survived time - {action.SurvivedTime}");
        }
    }
}