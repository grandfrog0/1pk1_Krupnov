namespace Task_32_01
{
    public class Kolobok
    {
        public int Position { get; private set; }
        public int Speed { get; }
        public bool IsAlive { get; private set; }
        public bool CanRoll { get; private set; }

        public Kolobok()
        {
            Position = 0;
            Speed = 1;
            IsAlive = true;
            CanRoll = true;
        }

        public void Roll()
        {
            if (CanRoll)
            {
                Position += Speed;
                Console.WriteLine($"Колобок катится, текущая позиция: {Position}");
            }
            else
            {
                Console.WriteLine("Колобок застрял..");
            }
        }

        // встреча с животным
        public void MeetAnimal(Animal animal)
        {
            if (animal.CanEat(this))
            {
                IsAlive = false;
                Console.WriteLine($"Колобок был съеден {animal.Name}!");
            }
            else
            {
                Console.WriteLine($"Колобок убежал от {animal.Name}!");
            }
        }

        // встреча с препятствием
        public void MeetObstacle(Obstacle obstacle)
        {
            if (obstacle.CanStop(this))
            {
                CanRoll = false;
                Console.WriteLine($"Колобок не может катиться из-за {obstacle.Name}: {obstacle.StopMessage}");
            }
            else
            {
                Console.WriteLine($"Колобок справился с {obstacle.Name}: {obstacle.IgnoreMessage}");
            }
        }
    }
}