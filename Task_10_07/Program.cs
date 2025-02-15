namespace Task_10_07
{
    internal class Program
    {
        /*
        Создайте метод, с помощью которого можно сгенерировать и вернуть символьный двумерный массив
        (состоящий из символов русского алфавита) и выведите на консоль данный массив с помощью другого метода
        (который принимает данный массив в качестве параметра)
        */

        static void Main(string[] args)
        {
            while (true)
            {
                // Узнаем число n у пользователя
                Console.WriteLine("Введите размерность массива n: ");
                string text = Console.ReadLine();
                int n = -1;
                while (!int.TryParse(text, out n) || n <= 0)
                {
                    Console.WriteLine("Введите число больше нуля.");
                    text = Console.ReadLine();
                }

                PrintCharArray(GenerateCharArray(n));
            }
        }

        static char[,] GenerateCharArray(int n)
        {
            // Создание массива, заполнение случайными символами
            char min = 'а', max = 'я';
            Random rnd = new Random();
            char[,] arr = new char[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = (char) rnd.Next((int)min, (int)max + 1);
                }

            return arr;
        }

        static void PrintCharArray(char[,] arr)
        {
            // Вывод массива
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
