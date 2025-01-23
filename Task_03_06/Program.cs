namespace Task_03_06
{
    internal class Program
    {
        //Написать программу, которая выводит таблицу значений функции: 𝑦=|𝑥|для -4≤x≤4, с шагом h = 0,5
        static void Main(string[] args)
        {
            Console.WriteLine("Таблица значений функции y=|x|");
            Console.WriteLine("  x  |  y  ");

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
