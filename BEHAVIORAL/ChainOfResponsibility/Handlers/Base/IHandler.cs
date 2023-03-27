namespace ChainOfResponsibility.Handlers.Base;

public interface IHandler {
    IHandler SetNext(IHandler handler);

    // this method is optional
    void Handle(object param);
}