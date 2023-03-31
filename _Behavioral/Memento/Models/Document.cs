using Memento.Models.Mementos;

namespace Memento.Models;

// originator class
public class Document {
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }

    public void Restore(DocumentMemento memento) {
        this.Name = memento.Name;
        this.Title = memento.Title;
        this.Content = memento.Content;
    }

    public DocumentMemento Save() {
        return new DocumentMemento(
            name: this.Name,
            title: this.Title,
            content: this.Content
        );
    }

    public override string ToString() => $"{this.Name}: {this.Title} {this.Content}";
}