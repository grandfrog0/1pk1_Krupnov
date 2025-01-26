namespace Task_05_07
{
    internal class Program
    {
        /*
        У пользователя в консоли запрашивается число n, генерируется квадратный массив целых числе [n*n].
        Заполнение случайными числами в диапазоне от 10 до 99 включительно.
        Найти и вывести отдельно минимальный элемент в матрице (LINQ под запретом) Осуществить умножение матрицы
        на ее минимальный элемент, при выводе цветом выделить пять максимальных значений в массиве 
        */
        static void Main(string[] args)
        {
            Console.Write("Длина массива (n): ");
            int n = Int32.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.Clear();
                Console.WriteLine("Введите размерность больше нуля!");
                Main(args);
                return;
            }
            int[,] arr = new int[n, n];

            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(10, 100);
                }
            }

            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    string add_text = "";
                    for (int x = 0; x <= 3 - arr[i, j].ToString().Length; x++) add_text += " ";
                    Console.Write(arr[i, j] + add_text);
                }
                Console.WriteLine();
            }

            int min_value = -1;
            for (int i = 0; i < arr.GetLength(0); i++) //Вычисления мин. значения
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] < min_value || min_value == -1) min_value = arr[i, j];
                }
            }
            for (int i = 0; i < arr.GetLength(0); i++) //Умножение массива на мин. значение
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] *= min_value;
                }
            }

            Console.WriteLine("Минимальное значение элемента: " + min_value);

            Console.WriteLine("Преобразованный массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    string add_text = "";
                    for (int x = 0; x <= 4 - arr[i, j].ToString().Length; x++) add_text += " ";
                    Console.Write(arr[i, j] + add_text);
                }
                Console.WriteLine();
            }
        }
    }
}
