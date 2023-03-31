namespace Bridge.Models.Devices;

using Bridge.Models.Devices.Base;

public class Tv : Device {
    public override void Off() => this.PowerButtonToggle();

    public override void On() => this.PowerButtonToggle();

    private void PowerButtonToggle() {
        this.isOn = !this.isOn;
        System.Console.WriteLine($"Log: {nameof(Tv)} is getting '{(this.isOn ? "ON" : "OFF")}'...");
    }
}