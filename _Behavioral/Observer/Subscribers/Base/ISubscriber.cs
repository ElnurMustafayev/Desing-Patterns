namespace Observer.Subscribers.Base;

using Observer.Publisher.Base;

public interface ISubscriber {
    void Update(PublisherBase publisher, string? notification = null);
}