namespace Task_03_07
{
    internal class Program
    {
        /*
        Написать программу, которая выводит таблицу скорости (через каждые 0,5с)
        свободно падающего тела v = g * t, где g = 9,8 м/с2 – ускорение свободного падения.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Скорость свободно падающего тела");
            Console.WriteLine("Введите время окончания (с)");
            int t_max = Int32.Parse(Console.ReadLine());

            float delta_time = 0.5f;
            float g = 9.8f;
            for (float t = 0; t < t_max; t += delta_time)
            {
                double v = g * t;
                v = Math.Round(v * 100) / 100;
                Console.Write($"t = {t}с; ");
                for (int i = 0; i < 10 - t.ToString().Length; i++) Console.Write(" ");
                Console.WriteLine($"v = {v}м/с");
            }
        }
    }
}
