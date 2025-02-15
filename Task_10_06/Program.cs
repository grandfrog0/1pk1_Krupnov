namespace Task_10_06
{
    internal class Program
    {
        //Создать метод ArrayGeneration, не возвращающий значения, который принимает целое число n, 
        //выводит на консоль сгенерированный массив размерности n*n.

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

                ArrayGeneration(n);
            }
        }

        static void ArrayGeneration(int n)
        {
            // Создание массива, заполнение случайными значениями
            Random rnd = new Random();
            int[,] arr = new int[n, n];
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rnd.Next(0, 100);
                }

            // Вывод массива
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    string add = "";
                    for (int k = 0; k < 3 - arr[i, j].ToString().Length; k++) add += "0";
                    Console.Write(add + arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
