namespace Task_32_01
{
    // расширить пример с колобком дополнительной логикой:
    // добавить препятствия не из мира животных, которые будут затормаживать его перемещение
    internal class Program
    {
        static void Main(string[] args)
        {
            Kolobok kolobok = new Kolobok();

            List<Animal> animals = new List<Animal>
            {
                new Hare(),
                new Wolf(),
                new Bear(),
                //new Fox()
            };

            foreach (var animal in animals)
            {
                if (!kolobok.IsAlive)
                    break;
                kolobok.Roll();
                kolobok.MeetAnimal(animal);
            }

            List<Obstacle> obstacles = new()
            {
                new Hole(),
                new Fence()
            };

            foreach (var obstacle in obstacles)
            {
                kolobok.Roll();
                kolobok.MeetObstacle(obstacle);
            }

            if (kolobok.IsAlive && kolobok.CanRoll)
            {
                Console.WriteLine("Колобок сбежал и стал Senior .NET-разработчиком!");
            }
            else
            {
                Console.WriteLine("Game Over. Колобок не выжил в этом жестоком ООП-мире.");
            }
        }

    }
}
