using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02.Publications
{
    internal class Dog
    {
        public string name;                 // имя пса
        public bool seenCat = false;        // видел ли кота
        Random rnd = new Random();
        string[] sounds = {"гав", "woof"};  // "лексикон" пса

        public void LookAtCat(Cat cat)
        {
            Console.WriteLine($"Пёс {name} увидел кота {cat.name}!");
            seenCat = true;
        }

        public void Sound()
        {
            // Берём случайную фразу пса..
            string sound = sounds[rnd.Next(0, sounds.Length)];
            string new_sound = "";

            // Увеличиваем количество повторений (лает чаще, если видел кота)
            for (int count = 0; count < rnd.Next(1, 3) + (seenCat ? 3 : 0); count++)
            {
                // С шансом меняем регистр (видевший кота пес будет немного громче)
                bool upper = rnd.Next(0, (int)(100 / (seenCat ? 1.5 : 1))) < 50;

                for (int i = 0; i < sound.Length; i++)
                {
                    new_sound += upper ? char.ToUpper(sound[i]) : char.ToLower(sound[i]);
                }

                new_sound += "-";
            }
            new_sound = new_sound.Remove(new_sound.Length - 1);

            Console.WriteLine(name + ": " + new_sound);
        }
    }
}
