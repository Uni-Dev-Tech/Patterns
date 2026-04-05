using System.Collections.Generic;

namespace Patterns.Composite
{
    public class Army : IUnit
    {
        private List<IUnit> _units = new List<IUnit>();

        public void Add(IUnit unit) => _units.Add(unit);
        public void Remove(IUnit unit) => _units.Remove(unit);

        public void Attack()
        {
            _units.ForEach(x => x.Attack());
        }

        public void Defence()
        {
            _units.ForEach(x => x.Defence());
        }

        public void Retreat()
        {
            _units.ForEach(x => x.Retreat());
        }
    }
}