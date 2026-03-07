using UnityEngine;

namespace Patterns.Strategy.Basic
{
    public class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Debug.Log("A strategy realization");
        }
    }
}