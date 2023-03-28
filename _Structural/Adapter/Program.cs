// Class to be adapted
using System.Text.Json;

public class Adaptee {
    public void SendSpecificRequest() {
        System.Console.WriteLine("Request send");
    }
}

public interface IAdapter {
    // another signature
    public void SendRequest();
}

public class Adapter : IAdapter {
    private readonly Adaptee adaptee;

    public Adapter(Adaptee? adaptee = null) => this.adaptee = adaptee ?? new Adaptee();

    // another signature
    public void SendRequest() {
        this.adaptee.SendSpecificRequest();
    }
}

public class Program {
    public static void Main() {
        var adaptee = new Adaptee();

        // ⛔️⛔️⛔️
        adaptee.SendSpecificRequest();

        // ✅✅✅
        // sometimes is better to use an adapter
        var adapter = new Adapter(adaptee);
        adapter.SendRequest();
    }
}