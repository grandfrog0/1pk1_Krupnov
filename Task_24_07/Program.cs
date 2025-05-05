using System.Diagnostics.Tracing;

namespace Task_24_07
{
    internal class Program
    {
        // Реализуйте функцию, которая ищет заданное слово в текстовом файле и возвращает все строки,
        // содержащие это слово (регистронезависимо).
        static void Main(string[] args)
        {
            List<string> rows = GetRowsWithWord("..\\..\\..\\example.txt", "кто");

            foreach(string row in rows)
                Console.WriteLine(row);
        }


        /// <summary>
        /// Поиск всех строк, где встречается данное слово
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="word">Искомое слово</param>
        /// <returns>Список строк с искомым словом</returns>
        static List<string> GetRowsWithWord(string path, string word)
        {
            List<string> result = new();
            string searchWord = word.ToLower();

            if (Path.Exists(path))
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line.ToLower().Split(" ,.;!?:-<>".ToCharArray());
                        if (words.Contains(searchWord) && !result.Contains(line))
                            result.Add(line);
                    }
                }
            }
            else Console.WriteLine($"Файл '{path}' не найден.");

            return result;
        }
    }
}
