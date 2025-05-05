using static System.Text.Encoding;

namespace Task_24_08
{
    internal class Program
    {
        // реализуйте функцию, осуществляющую поиск текста в файле
        // и его замену на значения, введенные пользователем
        static void Main(string[] args)
        {
            ReplaceText("..\\..\\..\\example.txt", "кто", "WHO");
        }

        /// <summary>
        /// Находит и заменяет текст в файле
        /// </summary>
        /// <param name="path">Путь к файлу</param>
        /// <param name="fromText">Первоначальный текст</param>
        /// <param name="toText">Новый текст</param>
        /// <param name="recursive">Изменить первое/все вхождения</param>
        static void ReplaceText(string path, string fromText, string toText)
        {
            if (Path.Exists(path))
            {
                string text = File.ReadAllText(path, encoding:UTF8);
                File.WriteAllText(path, text.Replace(fromText, toText), encoding:UTF8);
            }
            else Console.WriteLine($"Файл {path} не найден");
        }
    }
}
