namespace Decorator.Decorators;

using Decorator.Components.Base;
using Decorator.Decorators.Base;

public class ConcreteDecorator2 : BaseNotificationDecorator {
    public ConcreteDecorator2(NotificationComponentBase component) : base(component) {}

    public override void Send(string destination, string message) {
        System.Console.WriteLine("Decorator 2 start");

        base.Send(destination, message);

        System.Console.WriteLine("Decorator 2 end");
    }
}