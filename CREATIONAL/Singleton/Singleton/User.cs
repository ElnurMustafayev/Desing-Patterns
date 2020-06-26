namespace Singleton {
    public class User {
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string Group { get; set; }
        public IMessenger Messenger { get; set; }

        private User() {
            // Problem:
            // this.Messenger = new Messenger();

            // Solution:
            this.Messenger = MessengerSingleton.Instance.Messenger;
        }

        public User(string group, string firstName, string secondName) : this() {
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.Group = group;
        }

        public void SendMessage(string message) {
            Message newMessage = new Message(message, this);
            Messenger.Send(Group, newMessage);
        }

    }
}