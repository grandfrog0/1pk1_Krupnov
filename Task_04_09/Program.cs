namespace Task_04_09
{
    internal class Program
    {
        //В массиве найти элементы, которые в нем встречаются только один раз, и вывести их на экран.
        //То есть найти и вывести уникальные элементы массива.
        static void Main(string[] args)
        {
            Console.Write("Введите длину массива: ");
            int[] array = new int[Int32.Parse(Console.ReadLine())];

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

            Console.WriteLine("Уникальные элементы массива: ");
            for(int i = 0; i < array.Length; i++)
            {
                int count = 0;
                for(int j = 0; j < array.Length; j++) if (array[i] == array[j]) count++;
                if (count == 1) Console.Write(array[i] + " ");
            }
        }
    }
}
