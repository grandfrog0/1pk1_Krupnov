namespace Task_11_05
{
    internal class Program
    {
        //Комбинирование ref и out: Напишите метод, который принимает два числа по ссылке (ref) и
        //возвращает их сумму и произведение через выходные параметры(out).

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.Write("Введите число a: ");
                int a = ReadInt();

                Console.Write("Введите число b: ");
                int b = ReadInt();

                SumMult(ref a, ref b, out int sum, out int mult);
                Console.WriteLine($"Сумма равна {sum}, произведение равно {mult}");

                Console.ReadKey();
            }
        }

        /// <summary>
        /// Записывает сумму и произведение целых чисел в sum и mult соответственно.
        /// </summary>
        /// <param name="a">Ссылка на первое целое число</param>
        /// <param name="b">Ссылка на второе целое число</param>
        /// <param name="sum">Сумма чисел</param>
        /// <param name="mult">Произведение чисел</param>
        static void SumMult(ref int a, ref int b, out int sum, out int mult)
        {
            sum = a + b;
            mult = a * b;
        }

        /// <summary>
        /// Возвращает число, считываемое с консоли.
        /// </summary>
        /// <returns>int</returns>
        static int ReadInt()
        {
            string text = Console.ReadLine();
            int n = -1;
            while (!int.TryParse(text, out n))
            {
                Console.WriteLine("Введите целое число!");
                text = Console.ReadLine();
            }

            return n;
        }
    }
}
