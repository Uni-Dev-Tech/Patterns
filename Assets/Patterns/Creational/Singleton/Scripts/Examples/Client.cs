using UnityEngine;

namespace Patterns.Singleton
{
    public class Client : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var toAdd = GameConfigs.Instance.GameScoreSettings.ScoreValueToAdd;
                GameManager.Instance.AddScore(toAdd);
            }
        }
    }
}