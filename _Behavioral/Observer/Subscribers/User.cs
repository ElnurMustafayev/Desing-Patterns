namespace Observer.Subscriber;

using Observer.Publisher.Base;
using Observer.Subscribers.Base;

public class User : ISubscriber {
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Fullname => $"{this.Name} {this.Surname}";

    public User(string name, string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }

    public void Update(PublisherBase publisher, string? notification = null)
    {
        System.Console.Write($"{this.Fullname} received notification");

        if (string.IsNullOrWhiteSpace(notification) == false)
            System.Console.WriteLine($": {notification}");
    }
}