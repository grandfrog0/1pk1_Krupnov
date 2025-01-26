namespace Task_05_08
{
    internal class Program
    {
        /*
        Даны два массива размером 10*10, заполненные целыми числами в диапазоне от 1 до 9 вкл.
        Создать новый массив, который будет произведением двух предыдущих
        (перемножить элементы первых двух массивов, стоящие на одинаковых позициях и записать их в результирующий массив)
        Вывести результирующий массив
        */
        static void Main(string[] args)
        {
            int n = 10;
            int[,] arr1 = new int[n, n];
            int[,] arr2 = new int[n, n];

            Random rnd = new Random();
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i, j] = rnd.Next(1, 10);
                    arr2[i, j] = rnd.Next(1, 10);
                }
            }

            Console.WriteLine("Исходные массив: ");
            for (int i = 0; i < arr1.GetLength(0); i++)
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

            int[,] arr_new = new int[n, n];
            for (int i = 0; i < arr_new.GetLength(0); i++)
            {
                for (int j = 0; j < arr_new.GetLength(1); j++)
                {
                    arr_new[i, j] = arr1[i, j] * arr2[i, j];
                }
            }

            Console.WriteLine("Новый массив: ");
            for (int i = 0; i < arr_new.GetLength(0); i++)
            {
                for (int j = 0; j < arr_new.GetLength(1); j++)
                {
                    string add_text = "";
                    for (int x = 0; x <= 1 - arr_new[i, j].ToString().Length; x++) add_text += "0";
                    Console.Write(add_text);
                    Console.Write(arr_new[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
