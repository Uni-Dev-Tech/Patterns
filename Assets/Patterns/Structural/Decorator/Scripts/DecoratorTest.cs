using UnityEngine;

namespace Patterns.Decorator
{
    public class DecoratorTest : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q)) BasicAttack();
            else if (Input.GetKeyDown(KeyCode.W)) PoisonAttack();
            else if (Input.GetKeyDown(KeyCode.E)) FireAttack();
            else if (Input.GetKeyDown(KeyCode.R)) ComboAttack();
        }

        private void BasicAttack()
        {
            IEnemy enemy = new BasicEnemy();
            enemy.Attack();
        }

        private void PoisonAttack()
        {
            IEnemy enemy = new BasicEnemy();
            var poisonAttack = new PoisonDecorator(enemy);
            poisonAttack.Attack();
        }

        private void FireAttack()
        {
            IEnemy enemy = new BasicEnemy();
            var fireAttack = new FireEffectDecorator(enemy);
            fireAttack.Attack();
        }

        private void ComboAttack()
        {
            IEnemy enemy = new BasicEnemy();
            var poisonAttack = new PoisonDecorator(enemy);
            var comboAttack = new FireEffectDecorator(poisonAttack);
            comboAttack.Attack();
        }
    }
}