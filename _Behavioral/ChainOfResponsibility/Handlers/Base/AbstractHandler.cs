namespace ChainOfResponsibility.Handlers.Base;

public abstract class AbstractHandler : IHandler {
    IHandler? next;

    public virtual void Handle(object param) {
        // do some stuff
        System.Console.WriteLine($"Base logic: {this.GetType().Name} - '{param}'");

        this.next?.Handle(param);
    }

    public IHandler SetNext(IHandler handler) => this.next = handler;
}