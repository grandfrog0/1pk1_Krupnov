using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_02.Publications
{
    internal class Cat
    {
        public string name;                                 // имя кота
        public bool isMarch = false;                        // март ли на дворе
        Random rnd = new Random();
        string[] sounds = {"мяу", "мур", "mew", "meow"};    // "лексикон" кота

        public void Sound()
        {
            // Берём случайную фразу кота..
            string sound = sounds[rnd.Next(0, sounds.Length)];
            string new_sound = "";

            // Циклом изменяем текст
            for (int i = 0; i < sound.Length; i++)
            {
                // Удлиняем звук (звук длиннее, если на дворе март)
                for (int count = 0; count < rnd.Next(1, 3) + (isMarch ? 2 : 0); count++)
                {
                    // С шансом меняем регистр (мартовский кот будет громче)
                    if (rnd.Next(0, (int) (100 / (isMarch ? 1.5 : 1)) ) < 50)
                        new_sound += char.ToUpper(sound[i]);
                    else
                        new_sound += char.ToLower(sound[i]);
                }
            }

            Console.WriteLine(name + ": " + new_sound);
        }
    }
}
