using AbstractFactory.Entities.Base;

namespace AbstractFactory.Entities.Animlas;

public class Dog : Animal
{
    public Dog(string name) : base(name) { }

    public override void Say()
    {
        Console.WriteLine($"Dog {Name}: huf");
    }
}