using UnityEngine;

namespace Patterns.Bridge
{
    public class BridgeTest : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q)) UsePistol();
            else if (Input.GetKeyDown(KeyCode.W)) UseRifle();
        }

        private void UsePistol()
        {
            var shootMode = new SingleShot();
            var pistol = new Pistol(shootMode);
            pistol.Shoot();
        }

        private void UseRifle()
        {
            var shootMode = new BurstFire();
            var rifle = new Rifle(shootMode);
            rifle.Shoot();
        }
    }
}