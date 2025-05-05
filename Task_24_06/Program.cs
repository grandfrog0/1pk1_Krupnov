
namespace Task_24_06
{
    // Напишите метод, который принимает путь к файлу
    // и возвращает количество строк в нем. Используйте StreamReader.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetRowsLength("..\\..\\..\\example.txt"));
        }

        static int GetRowsLength(string path)
        {
            if (Path.Exists(path))
                using (StreamReader reader = new StreamReader(path))
                {
                    int count = 0;
                    while (reader.ReadLine() != null)
                        count++;
                    return count;
                }
            else
            {
                Console.WriteLine($"Файл '{path}' не найден.");
                return -1;
            }
        }
    }
}
