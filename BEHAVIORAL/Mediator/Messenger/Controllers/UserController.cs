using Messenger.Messages;
using Messenger.Messenger.Base;

namespace Messenger.Controllers;

class UserController {
    ICollection<UserInfoMessage> users = new List<UserInfoMessage>();
    private readonly IMessenger messenger;

    public UserController(IMessenger messenger) {
        this.messenger = messenger;

        this.messenger.Subscribe<UserInfoMessage>((message) => {
            if(message is UserInfoMessage userInfo) {
                Console.WriteLine($"User info received successfully in {nameof(UserController)}!\n");
                users.Add(userInfo);
            }
        });
    }

    public void ShowAllUsers() {
        if(this.users.Any() == false)
            return;

        foreach(var user in this.users)
            Console.WriteLine($"{user}\n");
    }
}