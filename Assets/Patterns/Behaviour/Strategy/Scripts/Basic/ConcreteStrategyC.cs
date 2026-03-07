using UnityEngine;

namespace Patterns.Strategy.Basic
{
    public class ConcreteStrategyC : IStrategy
    {
        public void Execute()
        {
            Debug.Log("C strategy realization");
        }
    }
}