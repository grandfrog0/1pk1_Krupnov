using Task_12_02.Publications;

namespace Task_12_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dogBob = new Dog() {name = "Bob"};
            Cat catTom = new Cat() {name = "Tom"};                          // Обычный кот
            Cat catJunior = new Cat() {name = "Junior", isMarch = true};    // Мартовский кот

            // Пес Боб даёт голос
            dogBob.Sound();
            dogBob.Sound();
            dogBob.Sound();

            Console.WriteLine();

            // Кот Том даёт голос
            catTom.Sound();
            catTom.Sound();
            catTom.Sound();

            Console.WriteLine();

            // Кот Джуниор даёт голос
            catJunior.Sound();
            catJunior.Sound();
            catJunior.Sound();

            Console.WriteLine();

            // Пес Боб увидел кота и снова даёт голос
            dogBob.LookAtCat(catTom);
            dogBob.Sound();
            dogBob.Sound();
            dogBob.Sound();
        }
    }
}
