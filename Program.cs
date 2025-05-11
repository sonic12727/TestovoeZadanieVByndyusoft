using System;
using System.Linq;

namespace SumTwoMinimums
{
    public class Program
    {
        public static int CalculateSumTwoMinimums(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Массив не может быть нулевым или пустым.");
            }
            
            if (numbers.Length < 2)
            {
                throw new ArgumentException("Массив должен содержать как минимум два числа.");
            }

            int firstMin = int.MaxValue;
            int secondMin = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < firstMin)
                {
                    secondMin = firstMin;
                    firstMin = number;
                }
                else if (number < secondMin)
                {
                    secondMin = number;
                }
            }

            if (firstMin == int.MaxValue || secondMin == int.MaxValue)
            {
                throw new InvalidOperationException("Не удалось найти два разных минимальных значения в массиве.");
            }
            return firstMin + secondMin;
        }
    }
}