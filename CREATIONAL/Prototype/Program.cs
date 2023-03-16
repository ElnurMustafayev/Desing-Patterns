namespace App;

public class IdInfo {
    public int Id;

    public IdInfo(int id) => this.Id = id;
}

public class Person {
    public string? Name { get; set; }
    public int? Age { get; set; }
    public IdInfo IdInfo { get; set; }

    public Person(int id) => this.IdInfo = new IdInfo(id);

    public Person ShallowCopy() => (Person)this.MemberwiseClone();
    public Person DeepCopy() {
        Person clone = (Person) this.MemberwiseClone();
        clone.IdInfo = new IdInfo(this.IdInfo.Id);
        return clone;
    }

    public override string ToString() => $"Id = '{this.IdInfo.Id}' Name = '{this.Name}' Age = '{this.Age}'";
}

class Perogram {
    public static void Main() {
        Person p1 = new Person(111);

        p1.Name = "Bob";
        p1.Age = 25;

        Person p2 = p1.ShallowCopy();
        Person p3 = p1.DeepCopy();

        p1.IdInfo.Id += 10;                     // Change ref type

        System.Console.WriteLine($"p1: {p1}");  // Id changed
        System.Console.WriteLine($"p2: {p2}");  // Id changed
        System.Console.WriteLine($"p3: {p3}");  // Id didn't change
    }
}