using Composite.Composits;
using Composite.Items;

var electronicsBox = new Box("Electronics");
electronicsBox.AddComponent(new Product(name: "phone", 1200));
electronicsBox.AddComponent(new Product(name: "tv", 800));

var fruitsBox = new Box("Fruits");
fruitsBox.AddComponent(new Product(name: "green apples", 10));
fruitsBox.AddComponent(new Product(name: "bananas", 7));
fruitsBox.AddComponent(new Product(name: "red apples", 15));

var rootBox = new Box("Order box");
rootBox.AddComponent(new Item("ticket"));
rootBox.AddComponent(electronicsBox);
rootBox.AddComponent(fruitsBox);
rootBox.AddComponent(new Item("draft"));


// Display
System.Console.WriteLine($"All Price: {rootBox.Price}");
rootBox.Display();

System.Console.WriteLine($"\nElectronics Price: {electronicsBox.Price}");
electronicsBox.Display();

System.Console.WriteLine($"\nFruits Price: {fruitsBox.Price}");
fruitsBox.Display();