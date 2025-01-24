namespace Task_04_05
{
    internal class Program
    {
        /*
        В массиве хранятся сведения о количестве осадков за месяц (30 дней).
        Необходимо определить общее количество осадков, выпавших за каждую декаду месяца,
        вывести день с самыми сильными осадками за месяц и отдельно вывести дни без осадков.
        Массив с осадками заполнятся с помощью рандома в диапазоне
        от 0 – нет осадков, до 300 мм выпавших осадков.
        */
        static void Main(string[] args)
        {
            int[] array = new int[30];

            //Присвоение случайных значений
            Random rnd = new Random();
            for(int i = 0; i < array.Length; i++)
                array[i] = rnd.Next(0, 300);

            //Вывод элементов массива
            Console.WriteLine("Осадки за месяц: ");
            foreach (int i in array)
                Console.Write(i + " ");
            Console.WriteLine();

            //Кол-во осадков за декаду месяца
            int decade_summ = 0;
            for(int i = 0; i < array.Length; i++)
            {
                decade_summ += array[i];
                if ((i + 1) % 10 == 0)
                {
                    Console.WriteLine($"Кол-во осадков, за {(i + 1) / 10} декаду месяца: {decade_summ}");
                    decade_summ = 0;
                }
            }

            // День с наиб. кол-вом осадков
            int max_index = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max_index]) max_index = i;
            }
            Console.WriteLine($"День с наибольшим кол-вом осадков: {max_index + 1}-й");

            // Дни без осадков
            int count = 0;
            foreach (int i in array) if (i == 0) count++;
            Console.WriteLine(count != 0 ? $"Дней без осадков: {count}." : "Дней без осадков нет.");
        }
    }
}
