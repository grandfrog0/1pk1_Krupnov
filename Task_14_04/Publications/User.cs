using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_04.Publications
{
    public class User
    {
        public static User CurrentUser { get; private set; }

        public string Username { get; private set; }

        public static void SetCurrentUser(User user)
        {
            CurrentUser = user;
            Console.WriteLine($"Текущий пользователь: {user.Username}");
        }

        public User(string username)
        {
            Username = username;
        }
    }
}
