using Observer.Publisher;
using Observer.Subscriber;
using Observer.Subscribers.Base;

var user1 = new User("Bob", "Marley");
var user2 = new User("Ann", "Brown");
var user3 = new User("John", "Black");

var users = new List<ISubscriber>() {
    user1, user2, user3
};

var task = new JiraTask(users);

task.Title = "Something";
task.State = TaskState.doing;