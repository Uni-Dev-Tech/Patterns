using UnityEngine;

namespace Patterns.MVC.Example
{
    public class ParticlesEnemyView : View<EnemyModel>
    {
        private ParticleSystem _damageFX, _healFX;

        public ParticlesEnemyView(EnemyModel model, EnemyInspector inspector) : base(model)
        {
            _damageFX = inspector.DamageFX;
            _healFX = inspector.HealFX;
        }

        protected override void OnSubscribeEvents()
        {
            Model.OnDamaged += OnDamaged;
            Model.OnHeal += OnHeal;
        }

        protected override void OnUnsubscribeEvents()
        {
            Model.OnDamaged -= OnDamaged;
            Model.OnHeal -= OnHeal;
        }

        private void OnDamaged(int value)
        {
            Debug.Log("Play damage FX!");
        }

        private void OnHeal(int value)
        {
            Debug.Log("Play healing FX!");
        }
    }
}