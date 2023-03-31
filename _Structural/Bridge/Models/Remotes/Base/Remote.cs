namespace Bridge.Models.Remotes.Base;

using Bridge.Models.Devices.Base;

// Asbtraction class
public class Remote {
    // Bridge
    public Device device { get; protected set; }

    public Remote(Device device) => this.device = device;

    public virtual void On() => device.On();
    public virtual void Off() => device.Off();
}