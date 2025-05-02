namespace Task_14_03
{
    // Реализуйте статический метод Factorial, который принимает целое число и возвращает его факториал.
    // Сделайте так, чтобы метод работал только для неотрицательных чисел.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите неотрицательное целое число, чтобы найти его факториал.");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "exit") break;
                if (int.TryParse(input, out int number))
                {
                    try
                    {
                        Console.WriteLine(Factorial(number));
                    }
                    catch (ArgumentOutOfRangeException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
                Console.WriteLine();
            }
        }

        static long Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException(number.ToString());

            long mult = 1;
            for (int i = 1; i <= number; i++)
            {
                mult *= i;
            }

            if (mult <= 0) throw new ArgumentOutOfRangeException(number.ToString());

            return mult;
        }
    }
}
