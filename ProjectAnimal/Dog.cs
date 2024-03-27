public class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof");
    }
    public override void Eat()
    {
        Console.WriteLine("The dog is eating");
    }
}