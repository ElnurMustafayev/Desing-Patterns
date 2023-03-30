namespace Decorator.Decorators.Base;

using Decorator.Components.Base;

public abstract class BaseNotificationDecorator : NotificationComponentBase {
    protected NotificationComponentBase wrappee;

    public BaseNotificationDecorator(NotificationComponentBase component) => this.wrappee = component;

    public override void Send(string destination, string message) => wrappee?.Send(destination, message);
}