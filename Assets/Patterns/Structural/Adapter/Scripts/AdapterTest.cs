using UnityEngine;

namespace Patterns.Adapter
{
    public class AdapterTest : MonoBehaviour
    {
        private void Start()
        {
            var enemy = new OldEnemy();
            IEnemy enemyAdapter = new EnemyAdapter(enemy);

            enemyAdapter.Attack();
        }
    }
}