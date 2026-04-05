using UnityEngine;

namespace Patterns.MVC.Example
{
    public class HighlightingEnemyView : View<EnemyModel>
    {
        private Color _damageColor, _healColor;

        public HighlightingEnemyView(EnemyModel model, EnemyInspector inspector) : base(model)
        {
            _damageColor = inspector.DamageColor;
            _healColor = inspector.HealColor;
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
            Debug.Log("Highlight damage color!");
        }

        private void OnHeal(int value)
        {
            Debug.Log("Highlight healing color!");
        }
    }
}