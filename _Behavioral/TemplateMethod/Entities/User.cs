namespace TemplateMethod.Entities;

public class User {
    public string name { get; set; }
    public string surname { get; set; }

    public override string ToString() => $"Name: '{this.name}' Surname: '{this.surname}'";
}