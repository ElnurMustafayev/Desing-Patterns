namespace ChainOfResponsibility.Handlers;

using ChainOfResponsibility.Handlers.Base;

public class Handler3 : AbstractHandler {
    public override void Handle(object param) {
        System.Console.WriteLine("Some Handle3 spesific stuff...");

        base.Handle(param);
    }
}