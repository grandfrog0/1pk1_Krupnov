namespace Task_11_02
{
    internal class Program
    {
        // Передача по ссылке (ref): Напишите метод, который принимает два целых числа по ссылке и
        // меняет их местами. Проверьте, изменились ли значения переменных вне метода
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;

            Console.WriteLine($"a до преобразований равен {a}, b равен {b}.");

            Swap(ref a, ref b);

            Console.WriteLine($"a после преобразований теперь равен {a}, b равен {b}.");
        }

        /// <summary>
        /// Меняет значения аргументов местами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Swap(ref int a, ref int b)
        {
            int val = a;
            a = b;
            b = val;

            Console.WriteLine($"Вызов метода Swap: a внутри метода равен {a}, b равен {b}.");
        }
    }
}
