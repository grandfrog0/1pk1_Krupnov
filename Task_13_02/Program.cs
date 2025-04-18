﻿using Task_13_02.Publications;

namespace Task_13_02
{
    /*
    Cоздать класс питомца.
      Cвойства:
        Кличка, вид животного, возраст, вес, отметка о состонии здоровья (здоров/нездоров).
      Методы:
        Вывод информации об объекте,
        Изменение значения веса животного,
        Изменение отметки о состоянии здоровья.
      Конструторы:
        Предусмотрите разные варианты инициализации объектов.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализация класса конструктором без аргументов
            Pet pet1 = new Pet();
            pet1.GetInfo();

            // меняем вес животного
            pet1.SetWeigth(15); 
            pet1.GetInfo();

            Pet pet2 = new Pet("Bob", "Doberman dog", 5, 12, "здоров");
            pet2.GetInfo();

            // меняем состояние здоровья
            pet2.SetHealthStatus("нездоров"); // или pet1.SetHealthStatus(false);
            pet2.GetInfo();
        }
    }
}
