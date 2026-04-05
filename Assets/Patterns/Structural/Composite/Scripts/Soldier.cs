using UnityEngine;

namespace Patterns.Composite
{
    public class Soldier : IUnit
    {
        public void Attack()
        {
            Debug.Log("Soldier attack!");
        }

        public void Defence()
        {
            Debug.Log("Soldier defence!");
        }

        public void Retreat()
        {
            Debug.Log("Soldier retreat!");
        }
    }

}