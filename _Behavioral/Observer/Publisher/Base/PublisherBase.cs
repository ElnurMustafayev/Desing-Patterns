namespace Observer.Publisher.Base;

using Observer.Subscribers.Base;

public class PublisherBase {
    protected ICollection<ISubscriber> subscribers;

    public PublisherBase(ICollection<ISubscriber> subscribers) {
        this.subscribers = subscribers;
    }

    public void AddSubscriber(ISubscriber subscriber) => this.subscribers.Add(subscriber);
    public void RemoveSubscriber(ISubscriber subscriber) => this.subscribers.Remove(subscriber);
}