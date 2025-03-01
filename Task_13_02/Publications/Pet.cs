using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_02.Publications
{
    /// <summary>
    /// Класс питомца
    /// </summary>
    internal class Pet
    {
        private bool isHealthy;

        public string Nickname      { get; private set; }   // кличка
        public string AnimalType    { get; private set; }   // вид питомца
        public int Age              { get; private set; }   // возраст
        public double Weight        { get; private set; }   // вес питомца
        public string HealthStatus                          // здоров ли питомец
        {
            get => isHealthy ? "здоров" : "нездоров";
        }

        /// <summary>
        /// Выводит информацию о питомце в консоль
        /// </summary>
        public void GetInfo()
        {
            Console.WriteLine($"Кличка: {Nickname},");
            Console.WriteLine($"Вид питомца: {AnimalType},");
            Console.WriteLine($"Возраст: {Age},");
            Console.WriteLine($"Вес: {Math.Round(Weight, 3)},");
            Console.WriteLine($"Состояние здоровья: {HealthStatus}.");
        }


        /// <summary>
        /// Задать новый вес питомцу
        /// </summary>
        /// <param name="weigth">Новый вес</param>
        public void SetWeigth(double weigth)
        {
            Weight = weigth;
        }

        /// <summary>
        /// Задать новый статус здоровья питомца
        /// </summary>
        /// <param name="isHealthy">Логическое значение</param>
        public void SetHealthStatus(bool isHealthy)
        {
            this.isHealthy = isHealthy;
        }

        /// <summary>
        /// Задать новый статус здоровья питомца
        /// </summary>
        /// <param name="status">Новый статус</param>
        public void SetHealthStatus(string status)
        {
            if (status == "здоров") isHealthy = true;
            else if (status == "нездоров") isHealthy = false;
            else Console.WriteLine("Некорректный статус здоровья.");
        }

        public Pet()
        {
            Nickname = "неизвестный";
            AnimalType = "неизвестный";
            Age = 1;
            Weight = 1;
            isHealthy = true;
        }

        public Pet(
            string nickname = "неизвестный", string animalType = "неизвестный",
            int age = 1, double weight = 1, bool isHealthy = true)
        {
            Nickname = nickname;
            AnimalType = animalType;
            Age = age;
            Weight = weight;

            SetHealthStatus(isHealthy);
        }

        public Pet(
            string nickname = "неизвестный", string animalType = "неизвестный",
            int age = 1, double weight = 1, string state = "")
        {
            Nickname = nickname;
            AnimalType = animalType;
            Age = age;
            Weight = weight;

            SetHealthStatus(state);
        }
    }
}
