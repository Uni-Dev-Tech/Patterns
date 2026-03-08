using UnityEngine;

namespace Patterns.Singleton
{
    [CreateAssetMenu(fileName = "GameConfigs", menuName = "Configs/GameConfigs")]
    public class GameConfigs : SingletonScriptableObject<GameConfigs>
    {
        [field: SerializeField] public GameScoreSettings GameScoreSettings { get; private set; }
    }
}