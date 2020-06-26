using System.Collections.Generic;

namespace Singleton {

	public interface IMessenger {
		void Send(string groupName, Message message);
	}

	public class Messenger : IMessenger {
		public Dictionary<string, List<Message>> Subscribers { get; private set; }
		public Messenger() => this.Subscribers = new Dictionary<string, List<Message>>();

		public void Send(string groupName, Message message) {
			// Add new group if there is none
			if(!this.Subscribers.ContainsKey(groupName))
				this.Subscribers[groupName] = new List<Message>();

			// Add message in chat
			this.Subscribers[groupName].Add(message);
		}
	}
}