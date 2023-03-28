using Decorator.Components.Base;

namespace Decorator.Components;

public class SlackNotification : NotificationComponentBase {
    public override void Send(string destination, string message) => System.Console.WriteLine($"Slack: {destination} => '{message}'");
}