namespace Task_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 14;
            double c = Math.PI / 4;

            double step1 = Math.Pow(b + Math.Pow(a - 1, 1.0 / 3.0), 1.0 / 4.0);
            double step2 = Math.Abs(a - b) * (Math.Pow(Math.Sin(c), 2) + Math.Tan(c));
            double step3 = step1 / step2;

            Console.WriteLine(step3);
        }
    }
}
