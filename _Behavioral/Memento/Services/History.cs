namespace Memento.Service;

using Memento.Models;
using Memento.Models.Mementos;

// Caretaker class
public class History {
    private Document originator;
    private ICollection<DocumentMemento> mementos = new List<DocumentMemento>();

    public History(Document document) {
        this.originator = document;

        this.Save();
    }

    // insert originator in history as memento
    public void Save() {
        var memento = this.originator.Save();
        this.mementos.Add(memento);
    }

    // edit originator to last memento
    public void Restore(int index = 0) {
        if(index >= this.mementos.Count)
            index = this.mementos.Count - 1;

        var lastMemento = this.mementos.SkipLast(index).Last();
        this.mementos.Remove(lastMemento);

        this.originator.Restore(lastMemento);
    }

    public void ShowHistory() {
        System.Console.WriteLine($"History of '{this.originator.Name}' document changes:");
        foreach (var memento in this.mementos)
            System.Console.WriteLine($"{memento.Date}: '{memento}'");
    }
}