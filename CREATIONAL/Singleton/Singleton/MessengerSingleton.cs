namespace Singleton {
    public class MessengerSingleton {
        // Return Instance object
        private static MessengerSingleton instance = null;
        public static MessengerSingleton Instance => instance ??= new MessengerSingleton(new Messenger());

        // Add Messenger in Instance
        public Messenger Messenger;
        private MessengerSingleton(Messenger messenger) => this.Messenger = messenger;  // Losing Injection
    }
}