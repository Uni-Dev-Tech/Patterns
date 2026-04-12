using UnityEngine;

namespace Patterns.ChainOfResponsibility
{
    public class ArmorHandler : DamageHandler
    {
        private int _absorbeValue;

        public ArmorHandler(int absorbeValue)
        {
            _absorbeValue = absorbeValue;
        }

        public override void Handle(DamageContext context)
        {
            if (context.Damage > 0)
            {
                context.Damage = Mathf.Max(0, context.Damage - _absorbeValue);
                Debug.Log($"Armor reduced damage. Remaining damage: {context.Damage}");
            }

            base.Handle(context);
        }
    }
}