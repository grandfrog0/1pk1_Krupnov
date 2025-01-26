namespace Task_05_09
{
    internal class Program
    {
        /*
        Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и выясните,
        является ли данная матрица Z-матрицей (это матрица, где все недиагональные элементы меньше нуля)
        Если данное условие выполняется то вывести данную матрицу с цветовой индикацией главной диагонали.
        Если не выполняется, то вывести сообщение что данная матрица не является Z-матрицей 
        */
        static void Main(string[] args)
        {
            Console.Write("Размерность массива: ");
            int n = Int32.Parse(Console.ReadLine());

            Console.Write("Учитывать побочную диагональ? (да/нет) ");
            bool use_side_diagonal = Console.ReadLine().Trim().ToLower() == "да";
            if (n <= 0)
            {
                Console.Clear();
                Console.WriteLine("Размер матрицы должен быть больше нуля!");
                Main(args);
                return;
            }
            int[,] arr = new int[n, n];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Элемент {i}, {j}=");
                    arr[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            bool is_diagonal = true;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j || (use_side_diagonal && i == n - j - 1)) continue;
                    if (arr[i, j] >= 0)
                    {
                        is_diagonal = false;
                        break;
                    }
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (is_diagonal && i == j) Console.BackgroundColor = ConsoleColor.Green;
                    else Console.BackgroundColor = ConsoleColor.Black;

                    Console.Write(arr[i, j] + " ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }

            if (is_diagonal) Console.WriteLine("Матрица является Z-матрицей.");
            else Console.WriteLine("Матрица не является Z-матрицей.");
        }
    }
}
