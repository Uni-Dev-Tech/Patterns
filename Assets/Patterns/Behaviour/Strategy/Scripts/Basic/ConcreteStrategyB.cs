using UnityEngine;

namespace Patterns.Strategy.Basic
{
    public class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Debug.Log("B strategy realization");
        }
    }
}