using Messenger.Messages.Base;

namespace Messenger.Messages;

public class UserInfoMessage : IMessage {
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public DateTime? Birthdate { get; set; }

    public override string ToString() {
        return @$"Name: {this.Name}
Surname: {this.Surname}
Birthdate: '{this.Birthdate?.ToShortDateString()}'";
    }
}