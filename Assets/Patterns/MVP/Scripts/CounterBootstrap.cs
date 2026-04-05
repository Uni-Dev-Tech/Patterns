using UnityEngine;

namespace Patterns.MVP
{
    public class CounterBootstrap : MonoBehaviour
    {
        [SerializeField] private CounterView _view;

        private CounterPresenter _presenter;
        private CounterModel _model;

        private void Awake()
        {
            _model = new CounterModel();
            _presenter = new CounterPresenter(_model, _view);

            _presenter.Initialize();
        }

        private void OnDestroy()
        {
            _presenter.Dispose();
        }
    }
}