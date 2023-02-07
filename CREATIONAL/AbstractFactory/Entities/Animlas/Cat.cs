using AbstractFactory.Entities.Base;

namespace AbstractFactory.Entities.Animlas;

public class Cat : Animal
{
    public Cat(string name) : base(name) { }

    public override void Say()
    {
        Console.WriteLine($"Cat {Name}: meow");
    }
}