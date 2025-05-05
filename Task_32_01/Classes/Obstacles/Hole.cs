namespace Task_32_01
{
    public class Hole : Obstacle
    {
        public Hole() : base("Ямка", "Ямка оказалась неглубокой.", "Ямка слишком глубокая, чтобы из нее выбраться.") { }

        public override bool CanStop(Kolobok kolobok)
        {
            return false;
        }
    }
}
