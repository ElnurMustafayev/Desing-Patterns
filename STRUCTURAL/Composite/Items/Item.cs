namespace Composite.Items;

// Component as ELEMENT
public class Item : Component {
    public Item(string name) : base(name, 0) {}

    public override void Display(int depth = 0) => System.Console.WriteLine($"{new string('-', depth)}{this.Name}");
}