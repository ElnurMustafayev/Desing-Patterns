namespace Composite.Composits;

// Component as CONTAINER
public class Box : Component {
    private List<Component> collection = new List<Component>();
    public override decimal Price => this.collection.Sum(component => component.Price);

    public void AddComponent(Component component) => this.collection?.Add(component);

    public Box(string name) : base(name, price: 0) {}

    public override void Display(int depth = 0) {
        System.Console.WriteLine($"{new string('=', depth)}{this.Name}");
        collection.ForEach(component => component.Display(depth + 2));
    } 
}