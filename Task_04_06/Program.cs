namespace Task_04_06
{
    internal class Program
    {
        /*
        Заполнить массив случайными положительными и отрицательными числами таким образом,
        чтобы все числа по модулю были разными. Это значит, что в массиве не может быть
        ни только двух равных чисел, но не может быть двух равных по модулю.
        В полученном массиве найти наибольшее по модулю число.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");
            int[] array = new int[Int32.Parse(Console.ReadLine())];
            int[] array_pos = new int[array.Length];

            //Заполнение массива случайными значениями
            Random rnd = new Random();
            int i = 0;
            while (i < array.Length)
            {
                int value = rnd.Next();
                if (Array.IndexOf(array_pos, value) != -1) continue;
                array[i] = value * (rnd.Next(0, 2) == 0 ? 1 : -1);
                array_pos[i] = value;
                i++;
            }
            Console.WriteLine("Содержимое массива: ");
            foreach (int el in array) Console.Write(el + " ");
            Console.WriteLine("");

            //Наибольшее по модулю число
            Console.WriteLine($"Наибольшее по модулю число: {array[Array.IndexOf(array_pos, array_pos.Max())]}");
        }
    }
}
