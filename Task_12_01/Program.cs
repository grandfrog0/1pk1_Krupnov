using Task_12_01.Publications;


namespace Task_12_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BooksMain();
            JournalsMain();
            NewspapersMain();
        }

        static void NewspapersMain()
        {
            Newspaper newspaper1 = new Newspaper()
            {
                publicationDate = "19.02.2025",
                title = "Правда?",
                headline = "В ГОРОДЕ НАЙДЕН НОВЫЙ..",
                pagesCount = 3,
                price = 30,
                content = new string[]
                {
                    // первая страница, 2 абзаца
                    "Продолжение в следующей газете!\n" +
                    "Ждите новые выпуски каждую среду."
                    // остальные страницы остаются пустыми
                }
            };

            Newspaper newspaper2 = new Newspaper()
            {
                publicationDate = "26.02.2025",
                title = "Правда?",
                headline = "ПРОДОЛЖЕНИЕ НОВОСТЕЙ ПРОШЛОЙ НЕДЕЛИ: В ГОРОДЕ НАЙДЕН НОВЫЙ..",
                pagesCount = 4,
                price = 47,
                content = new string[]
                {
                    "<Вырванная страница>",
                    "<Вырванная страница>",
                    "<Вырванная страница>",
                    "Ждите новые выпуски каждую среду."
                }
            };

            newspaper1.GetInfo();   // "В ГОРОДЕ НАЙДЕН НОВЫЙ.." - ГАЗЕТА "Правда" (3 стр.) (27.02.2024). Цена: 30 руб.
            newspaper1.View();      // Газету можно прочесть после покупки.
            newspaper1.Buy(30);     // Журнал "Правда?" куплен!
            newspaper1.View();

            Console.WriteLine();

            newspaper2.GetInfo();   // 
            newspaper2.Buy(100);    //
            newspaper2.View();

            Console.WriteLine();
        }

        static void JournalsMain()
        {
            Journal journal1 = new Journal()
            {
                publicationDate = "27.02.2024",
                subject = "метеорология",
                title = "О погоде",
                pagesCount = 6,
                price = 80.5
            };

            Journal journal2 = new Journal()
            {
                publicationDate = "30.11.2024",
                subject = "история",
                title = "Военно-исторический журнал",
                pagesCount = 21,
                price = 203,
                content = new string[]
                {
                    "Бюджета данного журнала хватило только на написание этого текста.",
                    "Спасибо за покупку!"
                }
            };


            journal1.GetInfo(); // Журнал "О погоде": метеорология (6 стр.) (27.02.2024). Цена: 80,5 руб.
            journal1.Buy(90);   // Журнал "О погоде" куплен!
            journal1.Buy();     // Журнал "О погоде" уже был куплен!
            journal1.View(1);   // Страница 1 пуста.

            Console.WriteLine();

            journal2.GetInfo(); // Журнал "Военно-исторический журнал": история (21 стр.) (30.11.2024). Цена: 203 руб.
            journal2.View(1);   // Перед прочтением, оплатите журнал!
            journal2.Buy(203);  // Журнал "Военно-исторический журнал" куплен!
            journal2.Buy(500);  // Журнал "Военно-исторический журнал" уже был куплен!
            journal2.View(1);
            journal2.View(2);
            journal2.View(3);

            Console.WriteLine();
        }

        static void BooksMain()
        {
            Book book1 = new Book();
            var book2 = new Book();
            var book3 = new Book() { title = "Автостопом по галактике", autor = "Дуглас Адамс" };
            Book book4 = new Book() { title = "Хоббит", autor = "Джон Толкин" };


            book1.autor = "Рей Бредберри";
            book1.title = "Марсианские хроники";
            book1.GetInfo();    //Рей Бредберри : Марсианские хроники

            book2.autor = "Джона Роулинг";
            book2.title = "Гарри Поттер и философский камень";
            book2.GetInfo();    //Джона Роулинг : Гарри Поттер и философский камень

            //выдача книги
            book2.GetBoot(); // книга выдана на неделю

            //попытка выдать уже занятую книгу
            book2.GetBoot(); // книга Гарри Поттер и философский камень в данный момент выдана другому читателю

            Console.WriteLine();
        }
    }
}
