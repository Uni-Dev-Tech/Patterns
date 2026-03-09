using UnityEngine;

namespace Patterns.Observer.Example
{
    public class NPC : MonoBehaviour
    {
        private HealthPublisher _healthPublisher;

        private void Start() => Initialize();

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Q)) _healthPublisher.AddHealth(10);
            else if (Input.GetKeyDown(KeyCode.W)) _healthPublisher.SubtractHealth(10);
        }

        private void Initialize()
        {
            _healthPublisher = new HealthPublisher();
            _healthPublisher.Attach(new HealthBarHealthObserver());
            _healthPublisher.Attach(new HighlightHealthObserver());
            _healthPublisher.Attach(new VFXHealthObserver());
        }
    }
}