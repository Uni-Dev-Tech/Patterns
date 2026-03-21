using UnityEngine;

namespace Patterns.EventBus.Example
{
    public class AnalysitcsSystem : MonoBehaviour
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
            Debug.Log($"AnalysitcsSystem got event callback!");
        }
    }
}