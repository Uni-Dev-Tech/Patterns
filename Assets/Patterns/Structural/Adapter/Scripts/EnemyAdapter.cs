using UnityEngine;

namespace Patterns.Adapter
{
    public class EnemyAdapter : IEnemy
    {
        private OldEnemy _oldEnemy;

        public EnemyAdapter(OldEnemy oldEnemy)
        {
            _oldEnemy = oldEnemy;
        }

        public void Attack()
        {
            _oldEnemy.AttackOldWay();
            Debug.Log("Attack using new systems!");
        }
    }
}