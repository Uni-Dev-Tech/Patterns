using UnityEngine;

namespace Patterns.Prototype
{
    public class PrototypeTest : MonoBehaviour
    {
        private void Start()
        {
            var weaponState = new WeaponStats("Rifle", 30, 0.2f);
            var clone = weaponState.Clone();

            Debug.Log($"{weaponState.Name}: DMG={weaponState.Damage}, Rate={weaponState.FireRate}");
            Debug.Log($"{clone.Name}: DMG={clone.Damage}, Rate={clone.FireRate}");
        }
    }
}