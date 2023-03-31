using Bridge.Models.Devices;
using Bridge.Models.Remotes;

// implementation
var device = new Scoreboard();

// abstraction
var remote = new RemoteWithLogger(device);  // bridge

remote.On();
remote.Off();

remote.ShowLogs();