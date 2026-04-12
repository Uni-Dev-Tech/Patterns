using UnityEngine;

namespace Patterns.MVVM
{
    public class CounterMVVMBootstrap : MonoBehaviour
    {
        [SerializeField] private CounterView _view;

        private void Awake()
        {
            var model = new CounterModel();
            var viewModel = new CounterViewModel(model);

            _view.Initialize(viewModel);
        }
    }
}