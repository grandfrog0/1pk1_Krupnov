namespace Task_32_01
{
    public class Bear : Animal
    {
        public Bear() : base("Медведь") { }
        public override bool CanEat(Kolobok kolobok)
        {
            return false; // Медведь оказался слишком медленным
        }
    }
}
