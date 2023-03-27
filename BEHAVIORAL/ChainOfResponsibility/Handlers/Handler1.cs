namespace ChainOfResponsibility.Handlers;

using ChainOfResponsibility.Handlers.Base;

public class Handler1 : AbstractHandler {
    public override void Handle(object param) {
        System.Console.WriteLine("Some Handle1 spesific stuff...");

        base.Handle(param);
    }
}