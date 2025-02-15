namespace Task_11_08
{
    internal class Program
    {
        //Использование params и out: Напишите метод, который принимает переменное количество
        //чисел и возвращает их сумму и максимальное значение через выходные параметры(out).

        static void Main(string[] args)
        {
            // Пример использования метода
            SumAndMax(out double sum, out double max, 42, 12, 14, 3, 0.2, 0.6, 3.2);
            Console.WriteLine($"Сумма: {sum}, максимальное значение: {max}");
        }

        /// <summary>
        /// Присваевает аргументам sum и max сумму и произведение чисел соответственно.
        /// </summary>
        /// <param name="sum">Сумма чисел.</param>
        /// <param name="max">Максимальное значение из всех чисел</param>
        /// <param name="nums">Массив переменного количества чисел</param>
        static void SumAndMax(out double sum, out double max, params double[] nums)
        {
            sum = 0;
            max = 0;

            foreach(double el in nums)
            {
                sum += el;
                if (el > max) max = el;
            }
        }
    }
}
