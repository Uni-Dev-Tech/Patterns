using UnityEngine;

namespace Patterns.Bridge
{
    public class Pistol : Weapon
    {
        public Pistol(IWeaponFire fireMode) : base(fireMode)
        {
        }

        public override void Shoot()
        {
            Debug.Log("Pistol shooting:");
            base.Shoot();
        }
    }
}