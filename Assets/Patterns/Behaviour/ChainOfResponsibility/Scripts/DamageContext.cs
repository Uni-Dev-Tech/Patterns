using UnityEngine;

namespace Patterns.ChainOfResponsibility
{
    public class DamageContext
    {
        public int Damage { get; set; }

        public DamageContext(int damage)
        {
            Damage = damage;
        }
    }
}