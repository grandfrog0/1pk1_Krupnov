using System.IO;

namespace Task_23_06
{
    /* Напишите программу со следующими функциями:
     * 1. Выведите информации о всех дисках в системе
     * 2. Выведите содержимое каталога C:\Users (названия папок)
     * 3. Создайте на диске D папку “work” и всю дальнейшую работу проводите в ней
     * a) Создание вложенного каталога “temp”
     * b) Вывод информации о текущем каталоге (имя, родитель и тд)
     * c) Вывод информации о вложенном каталоге
     * 4. Переместите каталог “temp” по пути “D:\work\newTemp”
     * a) Реализуйте вывод информационного сообщения об успешном (или нет) перемещении
     * 5. Удалите каталог “D:\work\temp” и выведите сообщение об успешном (или нет) удалении.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Вывод информации о всех дисках в системе.
            foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                Console.WriteLine($"Диск \"{driveInfo.Name}\":");
                Console.WriteLine($"Тип - {driveInfo.DriveType};");
                Console.WriteLine($"Полный размер - {driveInfo.TotalSize};"); 
                Console.WriteLine($"Места свободно  - {driveInfo.AvailableFreeSpace};");
            }
            Console.WriteLine();

            // Вывод содержимое каталога C:\Users (названия папок)
            Console.WriteLine("Содержимое каталога C:\\Users: ");
            Console.WriteLine(string.Join('\n', Directory.GetDirectories("C:\\Users")));
            Console.WriteLine();

            // Пропустим остальные пункты.. (отсутствует диск D) (._. )
            // На самом деле, сделаем все так, как в задании, но на диске C.

            // Создание на диске C папки "work" и всю дальнейшую работу проводите в ней 
            DirectoryInfo workDir = Directory.CreateDirectory("C:\\work");
            Console.WriteLine("Директория C:\\work успешно создана.");

            // Создание вложенного каталога "temp"
            DirectoryInfo tempDir = workDir.CreateSubdirectory("temp");
            Console.WriteLine("Директория C:\\work\\temp успешно создана.");

            // Вывод информации о текущем каталоге (имя, родитель и тд)
            DirectoryInfo curDir = new DirectoryInfo(Directory.GetCurrentDirectory());
            Console.WriteLine($"Текущий каталог: {curDir.Name}. Родитель {curDir.Parent}.");

            // Вывод информации о вложенном каталоге
            Console.WriteLine($"Кол-во вложенных каталогов: {curDir.GetDirectories().Length}");

            // Перемещение каталога "temp" по пути "C:\work\newTemp"
            if (Directory.Exists("C:\\work\\newTemp"))
            {
                Console.WriteLine("Не удается переместить каталог в C:\\work\\newTemp");
            }
            else
            {
                tempDir.MoveTo("C:\\work\\newTemp");
                Console.WriteLine("Успешно перемещено в каталог C:\\work\\newTemp");
            }

            // Удаление каталога "C:\work\temp".
            if (Directory.Exists("C:\\work\\temp"))
            {
                Directory.Delete("C:\\work\\temp", true);
                Console.WriteLine("Успешно удален каталог C:\\work\\temp");
            }
            else
            {
                Console.WriteLine("Каталог C:\\work\\temp не найден.");
            }
        }
    }
}
