namespace Task_05_06
{
    internal class Program
    {
        /*
        Осуществить генерация двумерного [10*5] массива по следующему правилу:
        - 1 столбец содержит нули
        - 2 столбце содержит числа кратные 2
        - 3 столбец содержит числа кратные 3
        - 4 столбец содержит числа кратные 4
        - 5 столбец содержит числа кратные 5
        Осуществить переворот массива (поменять строки и столбцы местами), вывести обновленный массив .
        */
        static void Main(string[] args)
        {
            int n = 10;
            int m = 5;
            int[,] arr = new int[n, m];
            int[,] arr_new = new int[m, n];

            for (int i = 1; i < arr.GetLength(0); i++)
            {
                int mult_value = i + 1;
                if (i == 0) mult_value = 0;

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = j * mult_value;
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
            for (int i = 0; i < arr_new.GetLength(0); i++)
            {
                for (int j = 0; j < arr_new.GetLength(1); j++)
                {
                    arr_new[i, j] = arr[j, i];

                    string add_text = "";
                    for (int x = 0; x <= 3 - arr_new[i, j].ToString().Length; x++) add_text += " ";
                    Console.Write(arr_new[i, j] + add_text);
                }
                Console.WriteLine();
            }
        }
    }
}
