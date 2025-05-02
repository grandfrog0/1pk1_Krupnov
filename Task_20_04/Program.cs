using Task_20_04.Publications;

namespace Task_20_04
{
    /* Создайте программу для учета транспортных средств. Используйте перечисление VehicleType:
     * Car
     * Bike
     * Bus
     * Truck
     * Motorcycle
     * Храните список транспортных средств (можно просто List<VehicleType>). 
     * Добавьте метод для подсчёта транспорта определённого типа (например, сколько грузовиков). 
     * Реализуйте поиск по типу и вывод информации.
     */

    internal class Program
    {
        static List<VehicleType> vehicles = new List<VehicleType>();

        static void Main(string[] args)
        {
            Fill();

            PrintCountOf(VehicleType.Car);
            PrintCountOf(VehicleType.Bike);
            PrintCountOf(VehicleType.Bus);
            PrintCountOf(VehicleType.Truck);
            PrintCountOf(VehicleType.Motorcycle);
        }

        static void Fill()
        {
            vehicles.Clear();
            for(int i = 0; i < Enum.GetValues<VehicleType>().Length; i++)
                for (int j = 0; j <= i; j++)
                    vehicles.Add((VehicleType)i);

            Console.WriteLine($"Содержимое списка: {string.Join(", ", vehicles)}");
        }

        /// <summary>
        /// Нахождение кол-ва транспортных средств определенного типа
        /// </summary>
        /// <param name="vehicleType"></param>
        /// <returns></returns>
        static int CountOf(VehicleType vehicleType)
        {
            int count = 0;
            foreach (VehicleType type in vehicles)
                if (type == vehicleType)
                    count++;
            return count;
        }

        static void PrintCountOf(VehicleType vehicleType)
        {
            Console.WriteLine($"Транспорт типа {vehicleType} находится в количестве {CountOf(vehicleType)} штук");
        }
    }
}
