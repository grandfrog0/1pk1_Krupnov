namespace Task_11_06
{
    internal class Program
    {
        // Передача массива по значению: Напишите метод, который принимает массив целых чисел и
        // изменяет его элементы, увеличивая каждый на 1. Проверьте, изменился ли оригинальный массив вне метода.

        static void Main(string[] args)
        {
            // Создаём массив целых чисел
            int n = ReadInt("Введите размер массива: ", onlyPositive: true);
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = ReadInt($"Введите {i + 1}-е число: ");
            }

            // Выводим массив до вызова метода
            Console.WriteLine("Массив до изменений: ");
            foreach(int el in arr) Console.Write(el + " ");
            Console.WriteLine();

            Increase(arr);

            // Выводим массив после вызова метода
            Console.WriteLine("Массив до изменений: ");
            foreach (int el in arr) Console.Write(el + " ");
            Console.WriteLine();
        }

        /// <summary>
        /// Увеличивает значение каждого элемента массива на единицу.
        /// </summary>
        /// <param name="arr">Массив целых чисел</param>
        static void Increase(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) arr[i]++;
        }

        /// <summary>
        /// Возвращает число, считываемое с консоли.
        /// </summary>
        /// <param name="write">Текст для вывода в консоль перед запросом числа.</param>
        /// <param name="onlyPositive">Вернуть только положительное число.</param>
        /// <returns></returns>
        static int ReadInt(string write = "", bool onlyPositive=false)
        {
            Console.Write(write);

            string text = Console.ReadLine();
            int n = -1;
            while (!int.TryParse(text, out n) || (onlyPositive && n <= 0))
            {
                Console.WriteLine("Введите целое число!");
                text = Console.ReadLine();
            }

            return n;
        }
    }
}
