namespace Patterns.MVVM
{
    public class CounterModel
    {
        private int _value;

        public int Value => _value;

        public void Increase() => _value++;
        public void Decrease() => _value--;
    }
}