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
            Console.Write("Размер стороны массива (n): ");
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
            Console.WriteLine("Минимальное значение элемента: " + min_value + "\n");

            for (int i = 0; i < arr.GetLength(0); i++) //Умножение массива на мин. значение
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] *= min_value;
                }
            }

            int[] max_values = new int[5];
            for (int c = 0; c < 5; c++)
            {
                foreach (int el in arr)
                {
                    for (int i = 0; i < max_values.Length; i++)
                    {
                        // Не допускается добавление элементов, которые больше или равны уже присутствующим в массиве
                        if (i >= 1 && el >= max_values[i - 1]) break;

                        if (max_values[i] < el) max_values[i] = el;
                    }
                }
            }
            Console.WriteLine("Максимальные значения элементов: " + String.Join(", ", max_values));

            Console.WriteLine("Преобразованный массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    foreach(int max_value in max_values) if (arr[i, j] ==  max_value) Console.BackgroundColor = ConsoleColor.Green;
                    string add_text = "";
                    for (int x = 0; x <= 4 - arr[i, j].ToString().Length; x++) add_text += " ";
                    Console.Write(arr[i, j]);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(add_text);
                }
                Console.WriteLine();
            }
        }
    }
}
