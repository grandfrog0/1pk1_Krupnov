namespace Task_11_01
{
    //Передача по значению: Напишите метод, который принимает два целых числа и меняет их
    //местами. Проверьте, изменились ли значения переменных вне метода
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 1;

            Console.WriteLine($"a до преобразований равен {a}, b равен {b}.");

            Swap(a, b);

            Console.WriteLine($"a после преобразований все ещё равен {a}, b также равен {b}.");
        }

        /// <summary>
        /// Локально меняет значения местами
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Swap(int a, int b)
        {
            int val = a;
            a = b;
            b = val;

            Console.WriteLine($"Вызов метода Swap: a внутри метода равен {a}, b равен {b}.");
        }
    }
}
