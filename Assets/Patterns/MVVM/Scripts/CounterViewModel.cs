namespace Patterns.MVVM
{
    public class CounterViewModel
    {
        private readonly CounterModel _model;

        public ObservableProperty<string> CounterText { get; } = new();

        public CounterViewModel(CounterModel model)
        {
            _model = model;
            UpdateView();
        }

        public void Increase()
        {
            _model.Increase();
            UpdateView();
        }

        public void Decrease()
        {
            _model.Decrease();
            UpdateView();
        }

        private void UpdateView()
        {
            CounterText.Value = $"Value: {_model.Value}";
        }
    }
}