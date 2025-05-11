using System;

namespace SumTwoMinimumsTests
{
    public class CalculatorTests
    {
        public static void RunTests()
        {
            TestValidArray();
            TestArrayWithNegativeNumbers();
            TestArrayWithDuplicateMinimums();
            TestArrayWithLargeNumbers();
            TestArrayWithAllSameNumbers();
            TestArrayWithMaxAndMinValues();
            TestEmptyArray();
            TestNullArray();
            TestArrayWithOneElement();
            Console.WriteLine("Тестирование прошло удачно.");
        }

        public static void TestValidArray()
        {
            int[] numbers = { 4, 0, 3, 19, 492, -10, 1 };
            int expectedSum = -10;
            int actualSum = SumTwoMinimums.Program.CalculateSumTwoMinimums(numbers);
            AssertEquals(expectedSum, actualSum, "TestValidArray");
        }

        public static void TestArrayWithNegativeNumbers()
        {
            int[] numbers = { -5, -2, -1, 0, 1 };
            int expectedSum = -7;
            int actualSum = SumTwoMinimums.Program.CalculateSumTwoMinimums(numbers);
            AssertEquals(expectedSum, actualSum, "TestArrayWithNegativeNumbers");
        }

        public static void TestArrayWithDuplicateMinimums()
        {
            int[] numbers = { 1, 0, 1, 0, 2 };
            int expectedSum = 0;
            int actualSum = SumTwoMinimums.Program.CalculateSumTwoMinimums(numbers);
            AssertEquals(expectedSum, actualSum, "TestArrayWithDuplicateMinimums");
        }

        public static void TestArrayWithLargeNumbers()
        {
            int[] numbers = { 1000000, 2000000, 50000, 60000 };
            int expectedSum = 110000;
            int actualSum = SumTwoMinimums.Program.CalculateSumTwoMinimums(numbers);
            AssertEquals(expectedSum, actualSum, "TestArrayWithLargeNumbers");
        }

        public static void TestArrayWithAllSameNumbers()
        {
            int[] numbers = { 5, 5, 5, 5, 5 };
            try
            {
                SumTwoMinimums.Program.CalculateSumTwoMinimums(numbers);
                Console.WriteLine("TestArrayWithAllSameNumbers: Ошибка исключения.");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("TestArrayWithAllSameNumbers: Пройдено удачно.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"TestArrayWithAllSameNumbers: Неправильный тип исключения: {e.GetType()}");
            }
        }

        public static void TestArrayWithMaxAndMinValues()
        {
            int[] numbers = { int.MaxValue, 1, int.MinValue, 2 };
            int expectedSum = int.MinValue + 1;
            int actualSum = SumTwoMinimums.Program.CalculateSumTwoMinimums(numbers);
            AssertEquals(expectedSum, actualSum, "TestArrayWithMaxAndMinValues");
        }

        public static void TestEmptyArray()
        {
            int[] numbers = { };
            try
            {
                SumTwoMinimums.Program.CalculateSumTwoMinimums(numbers);
                Console.WriteLine("TestEmptyArray: Ошибка исключения.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("TestEmptyArray: Пройдено удачно.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"TestEmptyArray: Неправильный тип исключения: {e.GetType()}");
            }
        }

        public static void TestNullArray()
        {
            int[] numbers = null;
            try
            {
                SumTwoMinimums.Program.CalculateSumTwoMinimums(numbers);
                Console.WriteLine("TestNullArray: Ошибка исключения.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("TestNullArray: Пройдено удачно.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"TestNullArray: Неправильный тип исключения: {e.GetType()}");
            }
        }

        public static void TestArrayWithOneElement()
        {
            int[] numbers = { 5 };
            try
            {
                SumTwoMinimums.Program.CalculateSumTwoMinimums(numbers);
                Console.WriteLine("TestArrayWithOneElement: Ошибка исключения.");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("TestArrayWithOneElement: Пройдено удачно.");
            }
            catch (Exception e)
            {
                Console.WriteLine($"TestArrayWithOneElement: Неправильный тип исключения: {e.GetType()}");
            }
        }

        private static void AssertEquals(int expected, int actual, string testName)
        {
            if (expected == actual)
            {
                Console.WriteLine($"{testName}: Пройдено удачно.");
            }
            else
            {
                Console.WriteLine($"{testName}: Ошибка. Ожидалось: {expected}, По факту: {actual}");
            }
        }
    }
}