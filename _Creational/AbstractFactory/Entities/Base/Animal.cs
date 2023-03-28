namespace AbstractFactory.Entities.Base;

public abstract class Animal {
    public string Name { get; protected set; }

    protected Animal(string name) => Name = name;

    public abstract void Say();
}