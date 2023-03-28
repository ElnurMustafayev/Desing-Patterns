namespace Composite;

public abstract class Component {
    public virtual decimal Price { get; set; }
    public string Name { get; set; }

    public Component(string name, decimal price) {
        this.Name = name;
        this.Price = price;
    }

    public virtual void Display(int depth = 0) => System.Console.WriteLine($"{new string('-', depth)}Component: {this.Price}");
}