using UnityEngine;

namespace Patterns.Builder
{
    public class WeaponTest : MonoBehaviour
    {
        private void Start()
        {
            var weapon = new WeaponBuilder()
                .SetName("Rifle")
                .SetDamage(40)
                .SetFireRate(0.2f)
                .AddScope()
                .AddSilencer()
                .SetMagazine(30)
                .Build();

            Debug.Log(weapon);
        }
    }
}