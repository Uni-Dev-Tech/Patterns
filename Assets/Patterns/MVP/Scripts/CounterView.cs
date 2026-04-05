using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

namespace Patterns.MVP
{
    public class CounterView : MonoBehaviour, ICounterView
    {
        [SerializeField] private Button _increaseButton;
        [SerializeField] private Button _decreaseButton;
        [SerializeField] private TextMeshProUGUI _text;

        public event Action IncreaseClicked;
        public event Action DecreaseClicked;

        private void OnEnable()
        {
            _increaseButton.onClick.AddListener(() => IncreaseClicked?.Invoke());
            _decreaseButton.onClick.AddListener(() => DecreaseClicked?.Invoke());
        }

        private void OnDisable()
        {
            _increaseButton.onClick.RemoveAllListeners();
            _decreaseButton.onClick.RemoveAllListeners();
        }

        public void UpdateText(int value)
        {
            _text.text = $"Value: {value}";
        }
    }
}