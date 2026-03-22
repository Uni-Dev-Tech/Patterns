using System;

namespace Patterns.Builder
{
    public class Weapon
    {
        public string Name { get; private set; }
        public int Damage { get; private set; }
        public float FireRate { get; private set; }
        public bool HasScope { get; private set; }
        public bool HasSilencer { get; private set; }
        public int MagazineSize { get; private set; }

        private bool _isBuilt = false;

        private void EnsureNotBuilt()
        {
            if (_isBuilt)
                throw new InvalidOperationException("Weapon already built");
        }

        public override string ToString()
        {
            return $"{Name}: DMG={Damage}, Rate={FireRate}, Scope={HasScope}, Silencer={HasSilencer}, Mag={MagazineSize}";
        }

        public void SetName(string name)
        {
            EnsureNotBuilt();
            if (string.IsNullOrWhiteSpace(name)) return;
            Name = name;
        }

        public void SetDamage(int damage)
        {
            EnsureNotBuilt();
            if (damage < 0) return;
            Damage = damage;
        }

        public void SetFireRate(float fireRate)
        {
            EnsureNotBuilt();
            if (fireRate < 0) return;
            FireRate = fireRate;
        }

        public void SetHasScope(bool hasScope)
        {
            EnsureNotBuilt();
            HasScope = hasScope;
        }

        public void SetHasSilencer(bool hasSilencer)
        {
            EnsureNotBuilt();
            HasSilencer = hasSilencer;
        }

        public void SetMagazineSize(int size)
        {
            EnsureNotBuilt();
            if (size <= 0) return;
            MagazineSize = size;
        }

        public void MarkAsBuilt() => _isBuilt = true;
    }
}