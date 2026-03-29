using UnityEngine;

namespace Patterns.Decorator
{
    public class FireEffectDecorator : EnemyDecorator
    {
        public FireEffectDecorator(IEnemy enemy) : base(enemy)
        {
        }

        public override void Attack()
        {
            base.Attack();

            Debug.Log("Add fire effect!");
        }
    }
}