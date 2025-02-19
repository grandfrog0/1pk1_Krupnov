using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12_01.Publications
{
    internal class Journal
    {
        public string publicationDate;  // дата публикации
        public string subject;          // тематика журнала
        public string title;            // наименование
        public int pagesCount;          // кол-во страниц
        public double price;            // цена журнала
        public string[] content;        // страницы с содержимым
        bool purchased;                 // куплен ли журнал

        // печатает в консоль информацию о журнале
        public void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Журнал \"{title}\": {subject} ({pagesCount} стр.) ({publicationDate}). Цена: {price} руб.");
            Console.ForegroundColor = ConsoleColor.White;
            if (purchased) Console.WriteLine("Уже куплен.");
        }

        /// <summary>
        /// Покупает журнал с проверкой, достаточно ли средств для покупки.
        /// </summary>
        /// <param name="payment">Оплата, предоставляемая покупаетелем.</param>
        public void Buy(double payment = 0)
        {
            if (purchased) Console.WriteLine($"Журнал \"{title}\" уже был куплен!");
            else if (payment < price) Console.WriteLine($"Недостаточно средств для покупки.");
            else
            {
                purchased = true;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Журнал \"{title}\" куплен!");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        /// <summary>
        /// Печатает в консоль текст, содержащийся на странице.
        /// </summary>
        /// <param name="page">Страница</param>
        public void View(int page)
        {
            if (!purchased)
            {
                Console.WriteLine("Перед прочтением, оплатите журнал!");
                return;
            }

            if (page < 1 || page > pagesCount) Console.WriteLine("Некорректный номер страницы.");
            else if (content == null || page > content.Length) Console.WriteLine($"Страница {page} пустая.");
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Страница {page}:");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(content[page - 1]);
            }
        }
    }
}
