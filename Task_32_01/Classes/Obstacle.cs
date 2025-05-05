namespace Task_32_01
{
    public abstract class Obstacle
    {
        public string Name { get; } // название препятствия
        public string IgnoreMessage { get; } // сообщение, почему колобок смог катиться дальше
        public string StopMessage { get; } // сообщение, почему колобок не смог катиться

        protected Obstacle(string name, string ignoreMessage, string stopMessage)
        {
            Name = name;
            IgnoreMessage = ignoreMessage;
            StopMessage = stopMessage;
        }

        public abstract bool CanStop(Kolobok kolobok);
    }
}
