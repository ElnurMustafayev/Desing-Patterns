namespace Bridge.Models.Devices;

using Bridge.Models.Devices.Base;

public class Scoreboard : Device {
    public override void Off() {
        if (this.isOn == false) {
            System.Console.WriteLine($"Warning: {nameof(Scoreboard)} is already 'OFF'!");
        }

        System.Console.Write("Press 'Enter' to confirm: ");
        if (Console.ReadKey().Key == ConsoleKey.Enter) {
            this.isOn = false;
            System.Console.WriteLine($"Log: {nameof(Scoreboard)} is getting 'OFF'...");
        }
    }

    public override void On() {
        this.isOn = true;
        System.Console.WriteLine($"Log: {nameof(Scoreboard)} is getting 'ON'...");
    }
}