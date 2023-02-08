using Messenger.Controllers;
using Messenger.Messenger.Base;

IMessenger messenger = new Messenger.Messenger.Messenger();
UserController userController = new UserController(messenger);
HomeController homeController = new HomeController(messenger);

homeController.Send("Elnur", "Mustafayev", new DateTime(2000, 8, 5));
homeController.Send("Bob", "Marley", new DateTime(1997, 2, 15));
homeController.Send("Ann", "German", new DateTime(1980, 11, 30));

userController.ShowAllUsers();