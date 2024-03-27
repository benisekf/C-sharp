using System;
public class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal is making some sound");
    }
    public virtual void Eat()
    {
        Console.WriteLine("Animal is eating");
    }
    public void Sleep()
    {
        Console.WriteLine("Animal is sleeping.");
    }
}