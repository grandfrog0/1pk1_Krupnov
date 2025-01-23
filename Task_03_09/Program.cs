namespace Task_03_09
{
    internal class Program
    {
        /*
        Вклад в банке составляет x рублей. Ежегодно он увеличивается на p процентов,
        после чего дробная часть копеек отбрасывается. Каждый год сумма вклада становится больше.
        Определите, через сколько лет вклад составит не менее y рублей.
        */
        static void Main(string[] args)
        {
            Console.Write("Введите начальный вклад: ");
            double x = Double.Parse(Console.ReadLine());
            Console.Write("Введите годовую процентную ставку (%): ");
            double p = Double.Parse(Console.ReadLine()) / 100;
            Console.Write("Введите итоговый счёт: ");
            double y = Double.Parse(Console.ReadLine());

            int years = 0;
            for (;x < y; x += x * p) years++;
            Console.WriteLine("Требуемый лет: " + years + "");
        }
    }
}
