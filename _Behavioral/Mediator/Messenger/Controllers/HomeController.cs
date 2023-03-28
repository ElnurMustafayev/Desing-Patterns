using Messenger.Messages;
using Messenger.Messenger.Base;

namespace Messenger.Controllers;

class HomeController {
    private readonly IMessenger messenger;

    public HomeController(IMessenger messenger) {
        this.messenger = messenger;
    }

    public void Send(string name, string surname, DateTime birthdate) {
        var message = new UserInfoMessage() {
            Name = name,
            Surname = surname,
            Birthdate = birthdate,
        };

        this.messenger.Send(message);
    }
}