using System.Dynamic;

namespace Task_10_08
{
    internal class Program
    {
        /*
        Создайте метод, который на вход принимает одномерный массив и число для поиска, 
        верните индекс искомого элемента в массиве. Если элемента нет – верните индекс = -1
        */

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                // Узнаем число размерность массива у пользователя
                Console.WriteLine("Введите размерность массива n: ");
                string text = Console.ReadLine();
                int n = -1;
                while (!int.TryParse(text, out n) || n <= 0)
                {
                    Console.WriteLine("Введите число больше нуля.");
                    text = Console.ReadLine();
                }

                // Получаем и выводим массив
                int[] arr = GenerateArray(n);
                PrintIntArray(arr);

                // Узнаем число для поиска, выводим индекс
                Console.WriteLine("Число для поиска: ");
                text = Console.ReadLine();
                int val = -1;
                while (!int.TryParse(text, out val))
                {
                    Console.WriteLine("Введите целое число!");
                    text = Console.ReadLine();
                }
                Console.WriteLine($"Индекс элемента в массиве: {GetIndex(arr, val)}");

                Console.ReadKey();
            }
        }

        /// <summary>
        /// Возвращает индекс числа в массиве
        /// </summary>
        /// <param name="arr">Массив целых чисел</param>
        /// <param name="val">Искомое число</param>
        /// <returns>int</returns>
        static int GetIndex(int[] arr, int val)
        {
            int index = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == val)
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        /// <summary>
        /// Возвращает сгенерированный массив целых чисел от 0 до 99
        /// </summary>
        /// <param name="n">Длина массива</param>
        /// <returns>int[,]</returns>
        static int[] GenerateArray(int n)
        {
            // Создание массива, заполнение случайными значениями
            Random rnd = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = rnd.Next(0, 100);

            return arr;
        }

        /// <summary>
        /// Выводит массив целых чисел в консоль
        /// </summary>
        /// <param name="arr">Массив для вывода</param>
        /// <returns></returns>
        static void PrintIntArray(int[] arr)
        {
            // Вывод массива
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
