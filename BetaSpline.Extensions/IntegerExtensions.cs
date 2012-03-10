using System;

namespace BetaSpline.Extensions
{
    public class IntegerExtensions
    {
        private readonly int number;

        public IntegerExtensions(int number)
        {
            this.number = number;
        }

        public void Times(Action action)
        {
            for (var index = 0; index < number; index++)
            {
                action.Invoke();
            }
        }

        public void Times(Action<int> action)
        {
            for (var index = 0; index < number; index++)
            {
                action.Invoke(index);
            }
        }
    }
}