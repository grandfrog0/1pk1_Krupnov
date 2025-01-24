namespace Task_04_07
{
    internal class Program
    {
        /*
        В массиве на 30 элементов содержатся данные по росту учеников в классе.
        Рост мальчиков условно задан отрицательными значениями.
        Вычислить и вывести количество мальчиков и девочек в классе и
        средний рост для мальчиков и девочек. При выводе избавиться от отрицательных значений.
        */
        static void Main(string[] args)
        {
            int[] array = new int[30];

            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(140, 200) * (rnd.Next(0, 2) * 2 - 1);
            }

            Console.WriteLine("Рост:");
            foreach (int i in array) Console.Write(i + " ");
            Console.WriteLine("");

            int girls_count = 0;
            int boys_count = 0;
            float girls_summ = 0;
            float boys_summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Sign(array[i]) != 1)
                {
                    boys_count++;
                    boys_summ += Math.Abs(array[i]);
                }
                else
                {
                    girls_count++;
                    girls_summ += array[i];
                }
            }
            Console.WriteLine("Кол-во мальчиков: " + boys_count);
            Console.WriteLine("Средний рост мальчиков: " + Math.Round(boys_summ / boys_count, 2));
            Console.WriteLine("Кол-во девочек: " + girls_count);
            Console.WriteLine("Средний рост девочек: " + Math.Round(girls_summ / girls_count, 2));
        }
    }
}
