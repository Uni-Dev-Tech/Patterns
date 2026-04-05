using System;

namespace Patterns.MVP
{
    public class CounterModel
    {
        private int _value;

        public int Value => _value;

        public event Action<int> OnValueChanged;

        public void Increase()
        {
            _value++;
            OnValueChanged?.Invoke(_value);
        }

        public void Decrease()
        {
            _value--;
            OnValueChanged?.Invoke(_value);
        }
    }
}