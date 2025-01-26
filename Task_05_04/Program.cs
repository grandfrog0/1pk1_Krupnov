namespace Task_05_04
{
    internal class Program
    {
        /*
        Дан квадратный массив размерность n*n. Произведите анализ данной матрицы и 
        выясните является ли данная матрица диагональной (все элементы вне главной диагонали равны нулю)
        Если матрица является диагональной, то вывести ее повторно с цветовым выделением главной диагонали.
        Если нет, то вывести сообщение, что матрица не является диагональной.
        */
        static void Main(string[] args)
        {
            Console.Write("Размерность массива: ");
            int n = Int32.Parse(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Размер матрицы должен быть больше нуля.");
                return;
            }
            int[,] arr = new int[n, n];
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for(int j = 0; j < arr.GetLength(1); j++)
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
                    if (i == j) continue;
                    if (arr[i, j] != 0)
                    {
                        is_diagonal = false;
                        break;
                    }
                }
            }

            for (int i = 0;i < arr.GetLength(0); i++)
            {
                for (int j = 0;j < arr.GetLength(1); j++)
                {
                    if (is_diagonal && i == j) Console.BackgroundColor = ConsoleColor.Green;
                    else Console.BackgroundColor = ConsoleColor.Black;

                    Console.Write(arr[i, j] + " ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }

            if (is_diagonal) Console.WriteLine("Матрица является диагональной.");
            else Console.WriteLine("Матрица не является диагональной.");
        }
    }
}
