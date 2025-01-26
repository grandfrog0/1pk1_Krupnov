namespace Task_05_05
{
    internal class Program
    {
        /*
        У пользователя в консоли запрашивается числа n и m, генерируется прямоугольный массив целых числе [n*m].
        Заполнение случайными числами в диапазоне от -99 до 99 включительно. Осуществите без создания
        нового массива преобразование текущего по следующему правилу:
        - Если элемент меньше нуля, то отбрасываем знак и выделяем при выводе зеленым цветом
        - Если элемент равен нулю, то перезаписываем единицу и выделяем при выводе красным цветом 
        */
        static void Main(string[] args)
        {
            Console.Write("Длина массива (n): ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Ширина массива (m): ");
            int m = Int32.Parse(Console.ReadLine());
            if (n <= 0 || m <= 0)
            {
                Console.Clear();
                Console.WriteLine("Введите размерность больше нуля!");
                Main(args);
                return;
            }
            int[,] arr = new int[n, m];

            Random rnd = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rnd.Next(-99, 100);
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

            Console.WriteLine("Преобразованный массив: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    string add_text = "";
                    int write_value = arr[i, j];
                    if (write_value < 0)
                    {
                        write_value = Math.Abs(write_value);
                        Console.BackgroundColor = ConsoleColor.Green;
                    }
                    else if (write_value == 0)
                    {
                        write_value = 1;
                        Console.BackgroundColor = ConsoleColor.Red;
                    }
                    for (int x = 0; x <= 3 - write_value.ToString().Length; x++) add_text += " ";
                    Console.Write(write_value);
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(add_text);
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
        }
    }
}
