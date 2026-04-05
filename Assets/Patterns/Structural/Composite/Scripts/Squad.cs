using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Composite
{
    public class Squad : IUnit
    {
        private List<IUnit> _units;

        public Squad(List<IUnit> units)
        {
            _units = units;
        }

        public void Attack()
        {
            Debug.Log("Squad attack!");
            _units.ForEach(x => x.Attack());
        }

        public void Defence()
        {
            Debug.Log("Squad defence!");
            _units.ForEach(x => x.Defence());
        }

        public void Retreat()
        {
            Debug.Log("Squad retreat!");
            _units.ForEach(x => x.Retreat());
        }
    }
}