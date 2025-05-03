namespace Task_21_01
{
    // Дан список чисел. Создать новый список,
    // содержащий только чётные числа из исходного списка, умноженные на 10.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину списка: ");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) && n > 0)
                Console.Write("Введите корректную длину списка! ");

            List<int> list1 = GenerateList(n);
            Console.WriteLine($"Первоначальный список: {string.Join(", ", list1)}");

            List<int> list2 = new();

            foreach (int el in list1)
                if (el % 2 == 0)
                    list2.Add(el * 10);

            Console.WriteLine($"Новый список: {string.Join(", ", list2)}");
        }

        static List<int> GenerateList(int length)
        {
            List<int> list = new();
            Random rnd = new();
            for (int i = 0; i < length; i++)
                list.Add(rnd.Next(0, 100));
            return list;
        }
    }
}
