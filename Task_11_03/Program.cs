namespace Task_11_03
{
    internal class Program
    {
        // Выходной параметр (out): Напишите метод, который принимает строку и возвращает через
        // выходной параметр количество гласных и согласных букв в этой строке
        static void Main(string[] args)
        {
            int vowels = 0; // гласные
            int consonants = 0; // согласные

            Console.WriteLine("Введите строку: ");
            string text = Console.ReadLine();

            GetLetters(text, out vowels, out consonants);

            Console.WriteLine("Гласных букв: " + vowels);
            Console.WriteLine("Согласных букв: " + consonants);
        }

        static string vowel_letters = "аоуэыяёюеиaeiouy";
        static string consonants_letters = "бвгджзйклмнпрстфхцчшщbcdfghjklmnpqrstvwxz";
        static void GetLetters(string text, out int vowels, out int consonants)
        {
            vowels = 0;
            consonants = 0;

            foreach(char el in text)
            {
                if (!char.IsLetter(el)) continue;
                char val = char.ToLower(el);
                if (val == 'ъ' || val == 'ь') continue;
                if (vowel_letters.IndexOf(val) != -1) vowels++;
                else if (consonants_letters.IndexOf(val) != -1) consonants++;
            }
        }
    }
}
