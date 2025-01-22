namespace Task_03_04
{   
    internal class Program
    {
        /*
        Пользователь вводить в консоли произвольный текст.
        После каждого ввода консоль очищается. Когда пользователь вводит
        слово «exit» или пустую строку – ввод останавливается и
        выводиться количество строк, введенных пользователем.
        */
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                string text = Console.ReadLine();
                Console.Clear();
                if (text == "exit" || text == "") break;
                count++;
            }
            Console.WriteLine("Введено произвольных строк: " + count);
        }
    }
}
