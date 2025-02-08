namespace Task_10_05
{
    internal class Program
    {
        /*Пользователь вводит целое неотрицательное число N,
         * программа с помощью процедурных методов должна
         * рассчитать и вывести площадь окружности с радиусом N
         * объем(4/3 Pi * R3 и площадь сфер с радиусом N
         * 
         * Осуществите бесконечный цикл для консолького
         * ввода числа и вызова метода
         * с выводом информации по выходному параметру
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число N");
            string text = Console.ReadLine();
            double N = -1;
            while (!double.TryParse(text, out N) || N <= 0)
            {
                Console.WriteLine("Введите число больше нуля.");
                text = Console.ReadLine();
            }

            PrintSphereCircleData(N);
        }

        static void PrintSphereCircleData(double r)
        {
            double sphereVolume = 4 / 3.0 * Math.PI * Math.Pow(r, 3);
            double sphereArea = 4 * Math.PI * Math.Pow(r, 2);
            double circleArea = Math.PI * r * r;

            Console.WriteLine("Объём сферы: " + Math.Round(sphereVolume, 3));
            Console.WriteLine("Площадь сферы: " + Math.Round(sphereArea, 3));
            Console.WriteLine("Площадь круга: " + Math.Round(circleArea, 3));
        }
    }
}
