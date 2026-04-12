using UnityEngine;
using TMPro;
using UnityEngine.UI;

namespace Patterns.MVVM
{
    public class CounterView : MonoBehaviour
    {
        [SerializeField] private Button _increaseButton;
        [SerializeField] private Button _decreaseButton;
        [SerializeField] private TextMeshProUGUI _text;

        private CounterViewModel _viewModel;

        public void Initialize(CounterViewModel viewModel)
        {
            _viewModel = viewModel;

            _increaseButton.onClick.AddListener(_viewModel.Increase);
            _decreaseButton.onClick.AddListener(_viewModel.Decrease);

            _viewModel.CounterText.OnValueChanged += UpdateText;
            UpdateText(_viewModel.CounterText.Value);
        }

        private void OnDestroy()
        {
            if (_viewModel != null)
                _viewModel.CounterText.OnValueChanged -= UpdateText;
        }

        private void UpdateText(string value)
        {
            _text.text = value;
        }
    }
}