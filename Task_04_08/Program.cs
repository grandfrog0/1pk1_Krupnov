namespace Task_04_08
{
    internal class Program
    {
        //Дан массив, содержащий последовательность 50 случайных чисел. 
        //Найти количество пар элементов, значения которых равны.
        static void Main(string[] args)
        {
            int[] array = new int[50];
            Random rnd = new Random();
            Console.Write("Введите максимальное число: ");
            int max = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(max);
            }
            Console.WriteLine("Элементы массива: ");
            foreach (int i in array) Console.Write(i + " ");
            Console.WriteLine("");

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j]) count++;
                }
            }
            Console.WriteLine("Пар одинаковых значений: " + count);
        }
    }
}
