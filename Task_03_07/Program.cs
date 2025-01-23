namespace Task_03_07
{
    internal class Program
    {
        /*
        Написать программу, которая выводит таблицу скорости(через каждые 0,5с)
        свободно падающего тела v = g*t, где g = 9,8 м/с2 – ускорение свободного падения.
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Скорость свободно падающего тела");
            Console.WriteLine("  t  |  v  ");

            float min = -4.3333f, max = 4;
            float h = 0.5f;
            for (float x = min; x <= max; x += h)
            {
                double rounded = Math.Round(x * 100) / 100; //Округляем X до сотых
                string text = rounded.ToString() + " ";
                if (text.Length < 6) for (int j = 0; j < 6 - text.Length; j++) text = text.Insert(0, " "); // Выравниваем текст пробелами слева
                text += Math.Abs(rounded);
                Console.WriteLine(text);
            }
        }
    }
}
