using System.Data;

namespace Task_02_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите год рождения:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите месяц рождения:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите день рождения:");
            int day = int.Parse(Console.ReadLine());

            DateTime today = DateTime.Now;
            int delta_day = today.Day - day;
            int delta_month = today.Month - month;
            if (delta_day < 0) delta_month--;
            int delta_year = today.Year - year;
            if (delta_month < 0) delta_year--;
            Console.WriteLine(delta_year >= 18 ? "Пользователь является совершеннолетним" : "Пользователь не является совершеннолетним");
        }
    }
}
