using Memento.Models;
using Memento.Service;

var originator = new Document() {
    Name = "Licence",
    Content = "Some template text here",
    Title = "MIT LICENCE",
};

History caretaker = new History(originator);

originator.Content = "Text changed";
caretaker.Save();
originator.Title = "Title changed";
caretaker.Save();
originator.Name = "Name changed";

caretaker.ShowHistory();
System.Console.WriteLine($"\nOriginator: {originator}");

caretaker.Restore(2);
System.Console.WriteLine($"Originator after restore: {originator}");