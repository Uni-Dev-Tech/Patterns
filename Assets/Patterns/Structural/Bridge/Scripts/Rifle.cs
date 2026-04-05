using UnityEngine;

namespace Patterns.Bridge
{
    public class Rifle : Weapon
    {
        public Rifle(IWeaponFire fireMode) : base(fireMode)
        {
        }

        public override void Shoot()
        {
            Debug.Log("Rifle shooting:");
            base.Shoot();
        }
    }
}