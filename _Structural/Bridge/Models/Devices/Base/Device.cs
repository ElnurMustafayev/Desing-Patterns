namespace Bridge.Models.Devices.Base;

// Implementation class
public abstract class Device {
    protected bool isOn;
    public abstract void On();
    public abstract void Off();
}