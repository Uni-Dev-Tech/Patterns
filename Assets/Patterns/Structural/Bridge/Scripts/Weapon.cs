namespace Patterns.Bridge
{
    public abstract class Weapon
    {
        protected IWeaponFire fireMode;

        public Weapon(IWeaponFire fireMode)
        {
            this.fireMode = fireMode;
        }

        public virtual void Shoot()
        {
            fireMode.Fire();
        }
    }
}