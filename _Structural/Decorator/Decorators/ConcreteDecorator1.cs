namespace Decorator.Decorators;

using Decorator.Components.Base;
using Decorator.Decorators.Base;

public class ConcreteDecorator1 : BaseNotificationDecorator {
    public ConcreteDecorator1(NotificationComponentBase component) : base(component) {}

    public override void Send(string destination, string message) {
        System.Console.WriteLine("Decorator 1 start");

        base.Send(destination, message);

        System.Console.WriteLine("Decorator 1 end");
    }
}