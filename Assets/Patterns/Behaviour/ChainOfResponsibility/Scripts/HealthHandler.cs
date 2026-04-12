using UnityEngine;

namespace Patterns.ChainOfResponsibility
{
    public class HealthHandler : DamageHandler
    {
        private int _health;

        public HealthHandler (int health)
        {
            _health = health;
        }

        public override void Handle(DamageContext context)
        {
            if (context.Damage > 0)
            {
                _health -= context.Damage;
                Debug.Log($"Health took {context.Damage}. Health left: {_health}");
                context.Damage = 0;
            }

            base.Handle(context);
        }
    }
}