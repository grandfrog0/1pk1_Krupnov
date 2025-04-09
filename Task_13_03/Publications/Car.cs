using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13_03.Publications
{
    class Car
    {
        private string _number;         // номер машины (строка, формата А000АА177)
        private string _brand;          // марка
        private string _color;          // цвет
        private float _curSpeed;        // текущая скорость машины
        private float _acceleration;    // ускорение
        private float _maxSpeed;        // максимальная скорость автомобиля

        public string Number { get => _number; private set => _number = value; }
        public string Brand { get => _brand; private set => _brand = value; }
        public string Color { get => _color; private set => _color = value; }
        public float Speed { get => _curSpeed; private set => _curSpeed = value; }
        public float Acceleration { get => _acceleration; private set => _acceleration = value; }
        public float MaxSpeed { get => _maxSpeed; private set => _maxSpeed = value; }

        /// <summary>
        /// Ускорение автомобиля
        /// </summary>
        /// <param name="time">время (в секундах)</param>
        public void Drive(float time = 1)
        {
            Speed += Acceleration * time / 60;
            if (Speed > MaxSpeed) Speed = MaxSpeed;

            Console.WriteLine($"Ускоряемся.. {Speed} км/ч\n");
        }

        /// <summary>
        /// Торможение
        /// </summary>
        /// <param name="time">время (в секундах)</param>
        public void SlowDown(float time = 1)
        {
            Speed -= Acceleration * time / 60;
            if (Speed < 0) Speed = 0;

            Console.WriteLine($"Тормозим.. {Speed} км/ч\n");
        }

        public Car(string number = "unregistered", string brand = "unnamed", string color = "white", float acceleration = 60, float maxSpeed = 200)
        {
            _number = number;
            _brand = brand;
            _color = color;
            _acceleration = acceleration;
            _maxSpeed = maxSpeed;
        }

        public Car(string number = "unregistered", string brand = "unnamed", float acceleration = 60, float maxSpeed = 200)
        {
            _number = number;
            _brand = brand;
            _color = "white";
            _acceleration = acceleration;
            _maxSpeed = maxSpeed;
        }

        public Car(string number = "unregistered", float acceleration = 60, float maxSpeed = 200)
        {
            _number = number;
            _brand = "unnamed";
            _color = "white";
            _acceleration = acceleration;
            _maxSpeed = maxSpeed;
        }

        public Car(float acceleration = 60, float maxSpeed = 200)
        {
            _number = "unregistered";
            _brand = "unnamed";
            _color = "white";
            _acceleration = acceleration;
            _maxSpeed = maxSpeed;
        }
    }
}
