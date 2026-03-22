namespace Patterns.Prototype
{
    public class WeaponStats : ICloneable<WeaponStats>
    {
        public string Name { get; private set; }
        public int Damage { get; private set; }
        public float FireRate { get; private set; }

        public WeaponStats(string name, int damage, float fireRate)
        {
            Name = name;
            Damage = damage;
            FireRate = fireRate;
        }

        public WeaponStats Clone() => new WeaponStats(this.Name, this.Damage, this.FireRate);
    }
}