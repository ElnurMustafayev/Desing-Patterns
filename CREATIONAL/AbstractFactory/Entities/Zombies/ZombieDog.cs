using AbstractFactory.Entities.Base;

namespace AbstractFactory.Entities.Zombies;

public class ZombieDog : Animal
{
    public ZombieDog(string name) : base(name) { }

    public override void Say()
    {
        Console.WriteLine($"Zombie dog {Name}: brainsss...");
    }
}