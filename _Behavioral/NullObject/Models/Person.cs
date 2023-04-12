namespace NullObject.Models;

public class Person {
    public virtual string Name { get; protected set; }

    public Person(string name) {
        this.Name = name;
    }

    public virtual void SayHi() {
        System.Console.WriteLine("Hi");
    }

    public void Info() {
        System.Console.WriteLine(this.Name);
        this.SayHi();
    }
}