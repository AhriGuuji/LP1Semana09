namespace AnimalKingdom
{
    public class Dog : Animal, IMammal
    {
        int IMammal.NumberOfNipples => 8;

        public override string Sound()
        {
            return base.Sound() + "Woof!";
        }
    }
}
