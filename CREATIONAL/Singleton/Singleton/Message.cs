using System;

namespace Singleton {
    public class Message {
        public DateTime SendTime { get; set; }
        public string Content { get; set; }
        public User Author { get; set; }

        private Message() => this.SendTime = DateTime.Now;

        public Message(string content, User author) : this() {
            this.Content = content;
            this.Author = author;
        }

        public override string ToString() => $"{this.Author.FirstName}: {this.Content}";
    }
}