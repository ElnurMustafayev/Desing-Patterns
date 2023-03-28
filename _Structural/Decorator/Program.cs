using Decorator.Components;
using Decorator.Decorators;
using Decorator.Decorators.Base;

var smsService = new SmsNotification();
var slackService = new SlackNotification();

// single decoration
BaseNotificationDecorator singleDecorator = new ConcreteDecorator1(slackService);
singleDecorator.Send("Elnur", "Test message...");

// multiple decoration
BaseNotificationDecorator multipleDecorator = new ConcreteDecorator2(new ConcreteDecorator1(smsService));

multipleDecorator.Send("+123456789", "Hello World!");