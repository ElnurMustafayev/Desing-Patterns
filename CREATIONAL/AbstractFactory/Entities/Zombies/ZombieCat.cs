using AbstractFactory.Entities.Base;

namespace AbstractFactory.Entities.Zombies;

public class ZombieCat : Animal
{
    public ZombieCat(string name) : base(name) { }

    public override void Say()
    {
        Console.WriteLine($"Zombie cat {Name}: brainsss...");
    }
}