using Decorator.Components.Base;

namespace Decorator.Components;

public class SmsNotification : NotificationComponentBase {
    public override void Send(string destination, string message) => System.Console.WriteLine($"SMS: {destination} => '{message}'");
}