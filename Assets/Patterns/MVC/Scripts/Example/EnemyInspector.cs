using System;
using UnityEngine;

namespace Patterns.MVC.Example
{
    [Serializable]
    public class EnemyInspector
    {
        [field: SerializeField, Header("GENERAL")] public int MaxHealth { get; private set; }

        [field: SerializeField, Header("PARTICLES")] public ParticleSystem DamageFX { get; private set; }
        [field: SerializeField] public ParticleSystem HealFX { get; private set; }

        [field: SerializeField, Header("HIGHLIGHT")] public Color DamageColor { get; private set; }
        [field: SerializeField] public Color HealColor { get; private set; }

        [field: SerializeField, Header("ANIMATION")] public Animator Animator { get; private set; }
    }
}