using UnityEngine;

namespace Patterns.Facade.Basic
{
    public class Client : MonoBehaviour
    {
        [SerializeField] private FacadeProvider _facadeProvider;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                _facadeProvider.Facade.Operation();
        }
    }
}