namespace Command.Commands;

using Command.Commands.Base;

public class SimpleCommand : ICommand {
    private static int counter = 0;
    public void Execute() {
        System.Console.WriteLine($"#{++counter} Simple command is working...");
    }
}