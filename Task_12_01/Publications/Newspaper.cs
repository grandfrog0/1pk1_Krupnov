using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01.Publications
{
    internal class Newspaper
    {
        public string publicationDate;  // дата публикации
        public string title;            // название газеты
        public string headline;         // заголовок
        public int pagesCount;          // кол-во страниц
        public double price;            // цена газеты
        public string[] content;        // страницы с содержимым
        bool purchased;                 // куплена ли газета

        // печатает в консоль информацию о газете
        public void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"\"{headline}\" - газета \"{title}\" ({pagesCount} стр.) ({publicationDate}). Цена: {price} руб.");
            Console.ForegroundColor = ConsoleColor.White;
            if (purchased) Console.WriteLine("Уже куплена.");
        }

        /// <summary>
        /// Покупает газету с проверкой, достаточно ли средств для покупки.
        /// </summary>
        /// <param name="payment">Оплата, предоставляемая покупаетелем.</param>
        public void Buy(double payment = 0)
        {
            if (purchased) Console.WriteLine($"Газета \"{title}\" уже была куплена!");
            else if (payment < price) Console.WriteLine($"Недостаточно средств для покупки.");
            else
            {
                purchased = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Газета \"{title}\" куплена!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /// <summary>
        /// Печатает в консоль текст газеты
        /// </summary>
        public void View()
        {
            if (!purchased)
            {
                Console.WriteLine("Газету можно прочесть после покупки.");
                return;
            }

            for (int i = 0; i < pagesCount; i++)
            {
                if (content == null || i >= content.Length) Console.WriteLine($"Страница {i + 1} пустая.");
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Страница {i + 1}:");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(content[i]);
                }
            }
        }
    }
}
