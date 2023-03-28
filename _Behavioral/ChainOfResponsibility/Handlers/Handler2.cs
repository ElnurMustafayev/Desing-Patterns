namespace ChainOfResponsibility.Handlers;

using ChainOfResponsibility.Handlers.Base;

public class Handler2 : AbstractHandler {
    public override void Handle(object param) {
        System.Console.WriteLine("Some Handle2 spesific stuff...");

        base.Handle(param);
    }
}