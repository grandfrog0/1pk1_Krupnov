namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());

            int delta_day = 20 - day;
            int delta_month = 1 - month;
            if (delta_day < 0) delta_month--;
            int delta_year = 2025 - year;
            if (delta_month < 0) delta_year--;
            Console.WriteLine(delta_year >= 18);
        }
    }
}
