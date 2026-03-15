using UnityEngine;

namespace Patterns.FactoryMethod
{
    public class ZombieFactory : EnemyFactory<ZombieEnemy>
    {
        public ZombieFactory(ZombieEnemy enemy) : base(enemy) { }

        public override ZombieEnemy Create(Vector3 position)
        {
            var zombie = base.Create(position);
            Debug.Log("Zombie created by factory");
            return zombie;
        }
    }

    public class RobotFactory : EnemyFactory<RobotEnemy>
    {
        public RobotFactory(RobotEnemy enemy) : base(enemy) { }

        public override RobotEnemy Create(Vector3 position)
        {
            var robot = base.Create(position);
            Debug.Log("Robot created by factory");
            return robot;
        }
    }

    public abstract class EnemyFactory<T> where T : MonoBehaviour, IEnemy
    {
        private T _prefab;

        public EnemyFactory(T prefab)
        {
            _prefab = prefab;
        }

        public virtual T Create(Vector3 position)
        {
            var enemy = GameObject.Instantiate(_prefab, position, Quaternion.identity);
            enemy.Initialize();
            return enemy;
        }
    }
}