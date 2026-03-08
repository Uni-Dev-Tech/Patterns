using UnityEngine;
using System;

namespace Patterns.Singleton
{
    [Serializable]
    public class GameScoreSettings
    {
        [field: SerializeField] public int ScoreValueToAdd { get; private set; }
    }
}