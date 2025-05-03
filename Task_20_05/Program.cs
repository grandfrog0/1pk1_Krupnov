namespace Task_20_05
{
    /* Напишите программу, имитирующую систему авторизации с использованием перечисления AccessLevel:
     * Guest (только чтение)
     * User (чтение + комментарии)
     * Moderator (удаление контента)
     * Admin (полный доступ)
     * Создайте метод, который проверяет, может ли пользователь выполнить действие (например, удалить пост).
     * На основе уровня доступа выводите сообщение (например, "Ошибка: Недостаточно прав!").
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= (int)AccessLevel.Admin; i++)
            {
                AccessLevel level = (AccessLevel)i;
                Console.WriteLine($"Уровень доступа: {level}");

                Console.Write("Попытка чтения: ");
                Read(level);

                Console.Write("Попытка комментирования: ");
                Comment(level);

                Console.Write("Попытка удаления: ");
                Delete(level);

                Console.WriteLine();
            }
        }

        static void Read(AccessLevel level)
        {
            Console.WriteLine("Чтение прошло успешно.");
        }

        static void Comment(AccessLevel level)
        {
            if ((int)level > (int)AccessLevel.Guest)
                Console.WriteLine("Комментарий отправлен.");
            else
                Console.WriteLine("Недостаточно прав.");
        }

        static void Delete(AccessLevel level)
        {
            if ((int)level > (int)AccessLevel.Moderator)
                Console.WriteLine("Удалено.");
            else
                Console.WriteLine("Недостаточно прав!");
        }
    }
}
