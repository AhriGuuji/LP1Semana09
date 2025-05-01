namespace AnimalKingdom
{
    public class Cat : Animal, IMammal
    {
        int IMammal.NumberOfNipples => 8;
        public override string Sound()
        {
            return base.Sound() + "Miau";
        }
    }
}
