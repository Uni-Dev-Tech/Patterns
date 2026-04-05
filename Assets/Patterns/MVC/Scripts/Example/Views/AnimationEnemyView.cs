using UnityEngine;

namespace Patterns.MVC.Example
{
    public class AnimationEnemyView : View<EnemyModel>
    {
        private Animator _animator;

        public AnimationEnemyView(EnemyModel model, EnemyInspector inspector) : base(model)
        {
            _animator = inspector.Animator;
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
            Debug.Log("Play damage animation!");
        }

        private void OnHeal(int value)
        {
            Debug.Log("Play healing animation!");
        }
    }
}