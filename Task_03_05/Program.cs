namespace Task_03_05
{
    internal class Program
    {
        /*
        Написать программу, которая выводит на экран таблицу соответствия 
        температуры в градусах Цельсия и Фаренгейта (F = C * 1,8 + 32).
        Диапазон изменения температуры в градусах Цельсия
        и шаг должны вводиться во время работы программы
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите минимальную температуру (в град. Цельсия)");
            int t_min = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите максимальную температуру (в град. Цельсия)");
            int t_max = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите шаг изменения температуры (в град. Цельсия)");
            int t_step = Int32.Parse(Console.ReadLine());

            for(int i = t_min; i <= t_max; i += t_step)
            {
                Console.WriteLine($"{i}C = {i * 1.8f + 32}F");
            }
        }
    }
}
