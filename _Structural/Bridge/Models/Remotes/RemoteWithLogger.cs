namespace Bridge.Models.Remotes;

using Bridge.Models.Devices.Base;
using Bridge.Models.Remotes.Base;

public class RemoteWithLogger : Remote {
    protected ICollection<string> history;

    public RemoteWithLogger(Device device, ICollection<string>? history = null) : base(device) {
        this.history = history ?? new List<string>();
    }

    public override void On() {
        history?.Add("'ON' button was pressed");
        base.On();
    }

    public override void Off() {
        history?.Add("'OFF' button was pressed");
        base.On();
    }

    public void ShowLogs() {
        for (int i = 0; i < this.history.Count; i++) {
            System.Console.WriteLine($"#{i}. {this.history.ElementAt(i)}");
        }
    }
}