namespace Composite.Items;

// Component as ELEMENT
public class Product : Component {
    public Product(string name, decimal price) : base(name, price) {}

    public override void Display(int depth = 0) => System.Console.WriteLine($"{new string('-', depth)}{this.Name}: {this.Price}");
}