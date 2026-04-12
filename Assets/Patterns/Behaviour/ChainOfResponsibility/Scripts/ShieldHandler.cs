using UnityEngine;

namespace Patterns.ChainOfResponsibility
{
    public class ShieldHandler : DamageHandler
    {
        private int _shieldHealth;

        public ShieldHandler(int shieldHealth)
        {
            _shieldHealth = shieldHealth;
        }

        public override void Handle(DamageContext context)
        {
            if (_shieldHealth > 0)
            {
                int absorbed = Mathf.Min(_shieldHealth, context.Damage);
                _shieldHealth -= absorbed;
                context.Damage -= absorbed;

                Debug.Log($"Shield absorbed {absorbed}. Shield left: {_shieldHealth}");
            }

            base.Handle(context);
        }
    }
}