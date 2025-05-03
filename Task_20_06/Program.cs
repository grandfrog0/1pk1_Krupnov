namespace Task_20_06
{
    /* Создайте программу, имитирующую работу светофора, используя перечисление TrafficLightColor:
     * Red
     * Yellow
     * Green
     * Реализуйте автоматическое переключение цветов (каждые 3 секунды). 
     * При смене цвета выводите его в консоль (можно с задержкой Thread.Sleep). 
     * Добавьте возможность ручного переключения (например, по нажатию клавиши).
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            TrafficLightColor color = TrafficLightColor.Red;
            List<ConsoleColor> consoleColors = new() { ConsoleColor.Red, ConsoleColor.Yellow, ConsoleColor.Green };
            bool manual = false;
            Console.WriteLine("Нажмите пробел чтобы сменить автоматическое управление на ручное.");

            while (true)
            {
                Console.ForegroundColor = consoleColors[(int)color];
                Console.WriteLine(color);
                Console.ForegroundColor = ConsoleColor.White;

                ConsoleKeyInfo manualKey = Console.ReadKey(false);
                if (manualKey.Key == ConsoleKey.Spacebar)
                {
                    manual = !manual;
                    if (manual)
                    {
                        Console.WriteLine("Выбран ручной режим. Нажмите пробел для отмены.");
                        Console.WriteLine("Нажмите 'r' чтобы выбрать красный, 'y' - для желтого, 'g' - для зеленого.");
                    }
                    else Console.WriteLine("Выбран автоматический режим. Нажмите пробел для возврата.");
                }

                if (manual)
                {
                    char k = manualKey.KeyChar;
                    if (k == 'r') color = TrafficLightColor.Red;
                    else if (k == 'y') color = TrafficLightColor.Yellow;
                    else if (k == 'g') color = TrafficLightColor.Green;
                }
                else
                {
                    Thread.Sleep(3000);
                    color = (TrafficLightColor)(((int)color + 1) % 3);
                }
            }
        }
    }
}
