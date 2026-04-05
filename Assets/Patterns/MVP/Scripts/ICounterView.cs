using System;

namespace Patterns.MVP
{
    public interface ICounterView
    {
        event Action IncreaseClicked;
        event Action DecreaseClicked;

        void UpdateText(int value);
    }
}