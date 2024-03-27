public class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Miau");
    }
    public override void Eat()
    {
        Console.WriteLine("The cat is eating");
    }
}