using UnityEngine;

namespace Patterns.Strategy.Basic
{
    public class Client : MonoBehaviour
    {
        private Context _context;
        private IStrategy _strategyA,
            _strategyB,
            _strategyC;

        private void Awake()
        {
            Initialize();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q)) StrategyA();
            else if (Input.GetKeyDown(KeyCode.W)) StrategyB();
            else if (Input.GetKeyDown(KeyCode.E)) StrategyC();
            else if (Input.GetKeyDown(KeyCode.Space)) ApplyStrategy();
        }

        private void Initialize()
        {
            _strategyA = new ConcreteStrategyA();
            _strategyB = new ConcreteStrategyB();
            _strategyC = new ConcreteStrategyC();

            _context = new Context(_strategyA);
        }

        private void StrategyA()
        {
            Debug.Log("Switch to strategy A");
            _context.SetStrategy(_strategyA);
        }

        private void StrategyB()
        {
            Debug.Log("Switch to strategy B");
            _context.SetStrategy(_strategyB);
        }

        private void StrategyC()
        {
            Debug.Log("Switch to strategy C");
            _context.SetStrategy(_strategyC);
        }

        private void ApplyStrategy()
        {
            _context.ApplyStrategy();
        }
    }
}