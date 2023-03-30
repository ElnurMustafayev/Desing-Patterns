namespace Decorator.Components.Base;

public abstract class NotificationComponentBase {
    public abstract void Send(string destination, string message);
}