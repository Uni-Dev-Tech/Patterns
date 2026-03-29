using UnityEngine;

namespace Patterns.Decorator
{
    public class PoisonDecorator : EnemyDecorator
    {
        public PoisonDecorator(IEnemy enemy) : base(enemy)
        {
        }

        public override void Attack()
        {
            base.Attack();

            Debug.Log("Add poison effect!");
        }
    }
}