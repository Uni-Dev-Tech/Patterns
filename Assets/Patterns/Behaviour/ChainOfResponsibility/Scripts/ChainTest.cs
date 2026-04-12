using UnityEngine;

namespace Patterns.ChainOfResponsibility
{
    public class ChainTest : MonoBehaviour
    {
        private IDamageHandler _chain;

        private void Awake()
        {
            Initialize();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                var damage = new DamageContext(25);
                _chain.Handle(damage);
            }
        }

        private void Initialize()
        {
            var shield = new ShieldHandler(20);
            var armour = new ArmorHandler(5);
            var health = new HealthHandler(100);

            shield.SetNext(armour).SetNext(health);
            _chain = shield;
        }
    }
}