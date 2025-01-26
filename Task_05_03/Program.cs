namespace Task_05_03
{
    internal class Program
    {
        /*
        Даны два массива, заполненные символами английского алфавита размером 3*3.
        Проверить, являются ли матрицы равными, если да, то вывести сообщение о том, что они равны, 
        если нет, то вывести повторно матрицы с цветовой индикацией только тех элементов, которые равны.
        (матрицы считаются равными, если их соответствующие элементы равны.)
        */
        static void Main(string[] args)
        {
            int n = 3;
            char[,] arr1 = new char[n, n];
            char[,] arr2 = new char[n, n];

            Random rnd = new Random();
            char c1 = 'a', c2 = 'z';
            for(int i = 0; i < arr1.GetLength(0); i++)
            {
                for(int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = (char) rnd.Next((int) c1, (int) c2 + 1);
                    arr2[i, j] = (char) rnd.Next((int) c1, (int) c2 + 1);
                }
            }

            for(int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    Console.Write(arr1[i, j] + " ");
                }
                Console.Write("\t");
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Равные элементы: ");

            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (arr1[i, j] == arr2[i, j]) Console.BackgroundColor = ConsoleColor.Green;
                    else Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(arr1[i, j] + " ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write("\t");
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    if (arr1[i, j] == arr2[i, j]) Console.BackgroundColor = ConsoleColor.Green;
                    else Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(arr2[i, j] + " ");
                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
        }
    }
}
