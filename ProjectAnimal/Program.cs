using System;
class Program
{
    static void Main(string[] args)
    {
        Cat myCat = new Cat();
        Dog myDog = new Dog();
        Fish myFish = new Fish();
        Chicken myChicken = new Chicken();
        myCat.MakeSound();
        myCat.Eat();
        myCat.Sleep();
        Console.WriteLine("");
        myDog.MakeSound();
        myDog.Eat();
        myDog.Sleep();
        Console.WriteLine("");
        myFish.MakeSound();
        myFish.Eat();
        myFish.Sleep();
        Console.WriteLine("");
        myChicken.MakeSound();
        myChicken.Eat();
        myChicken.Sleep();
    }
}