namespace Task_32_01
{
    public class Hare : Animal
    {
        public Hare() : base("Заяц") { }
        public override bool CanEat(Kolobok kolobok)
        {
            return false; // Заяц не смог съесть Колобка
        }
    }
}
