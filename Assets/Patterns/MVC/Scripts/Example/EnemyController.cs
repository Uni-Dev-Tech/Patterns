using UnityEngine;

namespace Patterns.MVC.Example
{
    public class EnemyController : Controller<EnemyModel>
    {
        [SerializeField] private EnemyInspector _inspector;

        protected override void ModelInitialize()
        {
            base.model = new EnemyModel(_inspector.MaxHealth);
        }

        protected override void ViewsInitialize()
        {
            base.InitializeView(new ParticlesEnemyView(base.model, _inspector));
            base.InitializeView(new HighlightingEnemyView(base.model, _inspector));
            base.InitializeView(new AnimationEnemyView(base.model, _inspector));
        }

        public void Heal(int value) => model.ApplyHeal(value);
        public void Damaged(int value) => model.ApplyDamage(value);
    }
}