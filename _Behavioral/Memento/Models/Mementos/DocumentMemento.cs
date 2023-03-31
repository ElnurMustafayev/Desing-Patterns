namespace Memento.Models.Mementos;

using System;
using Memento.Models.Mementos.Base;

// memento class
public class DocumentMemento : IMemento {
    #region Originator State

    // it is not necessary copy all data from originator
    public readonly string? Name;
    public readonly string? Title;
    public readonly string? Content;

    #endregion 

    private DateTime creationDate;
    public DateTime Date => this.creationDate;


    public DocumentMemento(string? name, string? title, string? content) {
        this.Name = name;
        this.Title = title;
        this.Content = content;

        this.creationDate = DateTime.Now;
    }

    public override string ToString() => $"{this.Name}: {this.Title} {this.Content}";
}