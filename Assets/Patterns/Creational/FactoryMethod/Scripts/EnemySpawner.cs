using UnityEngine;

namespace Patterns.FactoryMethod
{
    public class EnemySpawner : MonoBehaviour
    {
        [SerializeField] private ZombieEnemy _zombie;
        [SerializeField] private RobotEnemy _robot;

        private ZombieFactory _zombieFactory;
        private RobotFactory _robotFactory;

        private Vector3 _spawnPos = Vector3.zero;
        private Vector3 _offset = new Vector3(1, 0, 0);

        private void Start()
        {
            Initialize();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q))
            {
                _zombieFactory.Create(_spawnPos);
                _spawnPos += _offset;
            }

            if (Input.GetKeyDown(KeyCode.W))
            {
                _robotFactory.Create(_spawnPos);
                _spawnPos += _offset;
            }
        }

        private void Initialize()
        {
            _zombieFactory = new ZombieFactory(_zombie);
            _robotFactory = new RobotFactory(_robot);
        }
    }
}