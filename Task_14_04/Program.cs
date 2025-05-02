using Task_14_04.Publications;

namespace Task_14_04
{
    internal class Program
    {
        //Определите класс User, который будет иметь статическое свойство CurrentUser, 
        //представляющее текущего пользователя, и метод для его установки.

        static void Main(string[] args)
        {
            User user1 = new User("Николай");

            User.SetCurrentUser(user1);
            Console.WriteLine(User.CurrentUser.Username);

            User user2 = new User("Савелий");

            User.SetCurrentUser(user2);
            Console.WriteLine(User.CurrentUser.Username);
        }
    }
}
