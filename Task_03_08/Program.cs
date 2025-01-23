namespace Task_03_08
{
    internal class Program
    {
        //Даны натуральные числа от 20 до 50. Напечатать те из них, которые делятся на 3, но не делятся на 5.
        static void Main(string[] args)
        {
            Console.WriteLine("Натуральные числа от 20 до 50, кратные 3 и не кратные 5:");
            for (int i = 20; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 != 0) Console.WriteLine(i);
            }
        }
    }
}
