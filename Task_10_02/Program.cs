namespace Task_10_02
{
    internal class Program
    {
        /*Вычислить сумму: 1! + 2! + 3! + ... + n!
         * используя функцию вычисления факториала числа k
         * Использовать метод для нахлждения факториала (факториал находить через цикл)
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число n");
            string text = Console.ReadLine();
            int n = -1;
            while (!int.TryParse(text, out n) || n <= 0)
            {
                Console.WriteLine("Введите число больше нуля.");
                text = Console.ReadLine();
            }

            long result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += Factorial(n);
            }
            Console.WriteLine($"Сумма факториалов от 1 до {n} равен {result}");
        }

        /// <summary>
        /// Возвращает факториал числа
        /// </summary>
        /// <param name="k"></param>
        /// <returns></returns>
        public static long Factorial(int k)
        {
            long result = 1;
            for (int i = 1; i <= k; i++)
                result *= i;
            return result;
        }
    }
}
