using System;
using SumTwoMinimums;

namespace SumTwoMinimumsConsole
{
    class ProgramConsole
    {
        static void Main(string[] args)
        {
            int[] numbers = { 4, 0, 3, 19, 492, -10, 1 }; 
            try
            {
                int sum = Program.CalculateSumTwoMinimums(numbers);
                Console.WriteLine($"Сумма двух минимальных элементов: {sum}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Ошибка: {e.Message}");
            }

            Console.ReadKey();
        }
    }
}