namespace Observer.Publisher;

using Observer.Publisher.Base;
using Observer.Subscribers.Base;

public enum TaskState {
    backlog, todo, doing, test, done, released,
}

public class JiraTask : PublisherBase {
    private static int taskId = 0;
    public readonly int Id;

    private string? title;
    public string? Title {
        get => this.title;
        set {
            if (string.IsNullOrWhiteSpace(value) || this.title == value)
                return;

            var oldTitle = this.title;
            this.title = value;
            
            // notify all subsribers "Title was changed!"
            foreach (var subscriber in this.subscribers)
                subscriber.Update(this, $"Title was changed: [{oldTitle}] => [{this.title}]");
        }
    }

    private TaskState state = TaskState.backlog;
    public TaskState State
    {
        get { return state; }
        set {
            if (this.state == value)
                return;

            var oldState = this.state;
            this.state = value;

            // notify all subsribers "State was changed!"
            foreach (var subscriber in this.subscribers)
                subscriber.Update(this, $"State was changed: [{oldState}] => [{this.state}]");
        }
    }
    

    public string TaskName => $"Task-{this.Id} {this.Title}";

    public JiraTask(ICollection<ISubscriber> subscribers) : base(subscribers) {
        this.Id = ++taskId;
    }
}