namespace Task_21_02
{
    // Дан текст. Написать метод, который возвращает словарь,
    // где ключ — слово, а значение — количество его вхождений в тексте.
    internal class Program
    {
        static void Main(string[] args)
        {
            // Считываем пользовательский текст как строку и разделяем на отдельные слова
            Console.WriteLine("Напишите текст: ");
            string[] words = Console.ReadLine().Split(",.;:!? ".ToCharArray());

            Dictionary<string, int> dict = new();
            foreach(string word in words)
            {
                if (",.;:!? ".Contains(word)) continue;
                if (!dict.ContainsKey(word)) dict[word] = 1;
                else dict[word]++;
            }

            Console.WriteLine($"Получившийся словарь: \n{string.Join('\n', dict)}");
        }
    }
}
