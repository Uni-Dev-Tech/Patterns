namespace Patterns.MVP
{
    public class CounterPresenter
    {
        private readonly CounterModel _model;
        private readonly ICounterView _view;

        public CounterPresenter(CounterModel model, ICounterView view)
        {
            _model = model;
            _view = view;
        }

        public void Initialize()
        {
            _view.IncreaseClicked += OnIncreaseClicked;
            _view.DecreaseClicked += OnDecreaseClicked;

            _model.OnValueChanged += OnValueChanged;

            _view.UpdateText(_model.Value);
        }

        public void Dispose()
        {
            _view.IncreaseClicked -= OnIncreaseClicked;
            _view.DecreaseClicked -= OnDecreaseClicked;

            _model.OnValueChanged -= OnValueChanged;
        }

        private void OnIncreaseClicked()
        {
            _model.Increase();
        }

        private void OnDecreaseClicked()
        {
            _model.Decrease();
        }

        private void OnValueChanged(int value)
        {
            _view.UpdateText(value);
        }
    }
}