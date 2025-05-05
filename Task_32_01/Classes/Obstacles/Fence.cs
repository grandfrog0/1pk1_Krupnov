namespace Task_32_01
{
    public class Fence : Obstacle
    {
        public Fence() : base("Забор", "В заборе была дыра.", "Забор слишком высокий!") { }

        public override bool CanStop(Kolobok kolobok)
        {
            return true;
        }
    }
}
