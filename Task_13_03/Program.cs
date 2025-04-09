using Task_13_03.Publications;

namespace Task_13_03
{
    /*создайте класс автомобиля. 
     * Свойства:
     * номер авто, марка, цвет, текущая скорость
     * Методы:
     * езда (симитировать равномерное ускорение скорости автомобиля)
     * торможение (при превышении скорости автомобиля свыше допустимой - он должен остановиться)
     * Конструторы:
     * предусмотрите разные варианты инициализации объектов
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            string commands = "Напишите команду:\nУскориться X - ускорение на протяжении Х секунд;\n" +
                              "Тормозить X - торможение на протяжении Х секунд;\n" +
                              "Очистить - очистить чат;\n" +
                              "Завершить - завершить работу программы.";
            Console.WriteLine(commands);

            Car toyota = new Car("У890СК56", "Toyota", "white", 60, 200);
            while (true)
            {
                string text = Console.ReadLine().ToLower().Trim();
                if (text.StartsWith("ускориться ") && int.TryParse(text.Split()[1], out int t))
                {
                    toyota.Drive(t);
                }
                else if (text.StartsWith("тормозить ") && int.TryParse(text.Split()[1], out t))
                {
                    toyota.SlowDown(t);
                }
                else if (text == "очистить")
                {
                    Console.Clear();
                    Console.WriteLine(commands);
                }
                else if (text == "завершить")
                {
                    break;
                }
            }
        }
    }
}
