namespace Patterns.Builder
{
    public class WeaponBuilder
    {
        private Weapon _weapon = new Weapon();

        public WeaponBuilder SetName(string name)
        {
            _weapon.SetName(name);
            return this;
        }

        public WeaponBuilder SetDamage(int damage)
        {
            _weapon.SetDamage(damage);
            return this;
        }

        public WeaponBuilder SetFireRate(float rate)
        {
            _weapon.SetFireRate(rate);
            return this;
        }

        public WeaponBuilder AddScope()
        {
            _weapon.SetHasScope(true);
            return this;
        }

        public WeaponBuilder AddSilencer()
        {
            _weapon.SetHasSilencer(true);
            return this;
        }

        public WeaponBuilder SetMagazine(int size)
        {
            _weapon.SetMagazineSize(size);
            return this;
        }

        public Weapon Build()
        {
            var result = _weapon;
            result.MarkAsBuilt();

            _weapon = new Weapon(); // reset

            return result;
        }
    }
}