using UnityEngine;

namespace Patterns.Bridge
{
    public class SingleShot : IWeaponFire
    {
        public void Fire()
        {
            Debug.Log("Single shot!");
        }
    }
}