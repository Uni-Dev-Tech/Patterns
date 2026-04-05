using System.Collections.Generic;
using UnityEngine;

namespace Patterns.Composite
{
    public class CompositeTest : MonoBehaviour
    {
        private Army _army;

        private void Start() => Initialize();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q)) Attack();
            else if (Input.GetKeyDown(KeyCode.W)) Defence();
            else if (Input.GetKeyDown(KeyCode.E)) Retreat();
        }

        private void Initialize()
        {
            var soldier1 = new Soldier();
            var soldier2 = new Soldier();

            var squad1 = new Squad(new List<IUnit>() { soldier1, soldier2 });

            var soldier3 = new Soldier();
            var soldier4 = new Soldier();

            var squad2 = new Squad(new List<IUnit>() { soldier3, soldier4 });

            _army = new Army();
            _army.Add(squad1);
            _army.Add(squad2);
        }

        private void Attack() => _army.Attack();
        private void Defence() => _army.Defence();
        private void Retreat() => _army.Retreat();
    }
}