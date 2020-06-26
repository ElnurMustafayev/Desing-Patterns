using System;

namespace Singleton {
    class Program {
        static void Main() {
            // Add users
            User john = new User("Group1", "John", "Brown");
            User bob = new User("Group1", "Bob", "Black");
            User aloneUser = new User("Group2", "Alone", "Forever");

            // Users send messages
            john.SendMessage("Hello everyone!");
            bob.SendMessage("Hi John!");
            aloneUser.SendMessage("Hey!!!");

            // Show all groups' messages
            (john.Messenger as Messenger).Subscribers["Group1"].ForEach(m => Console.WriteLine(m));
            Console.WriteLine("\n- - - - - - - - - - - - - - \n");
            (john.Messenger as Messenger).Subscribers["Group2"].ForEach(m => Console.WriteLine(m));
        }
    }
}