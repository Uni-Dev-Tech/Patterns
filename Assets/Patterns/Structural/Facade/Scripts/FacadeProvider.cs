using UnityEngine;

namespace Patterns.Facade.Basic
{
    public class FacadeProvider : MonoBehaviour
    {
        public Facade Facade { get; private set; }

        private void Start()
        {
            Facade = new Facade(new SubsystemA(), new SubsystemB());
        }
    }
}