using UnityEngine;

namespace Patterns.Bridge
{
    public class BurstFire : IWeaponFire
    {
        public void Fire()
        {
            Debug.Log("Burst fire!");
        }
    }
}