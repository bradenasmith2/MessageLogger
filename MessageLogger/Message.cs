using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;

namespace MessageLogger
{
    public class Message
    {
        public string Content;
        public DateTime CreatedAt;
        public List<string> AllMessages;
        public string shortTime;
        public DateTime Time;

        public Message(string content, DateTime time)
        {
            Content = content;
            CreatedAt = DateTime.Now;
            AllMessages = new List<string>();
            shortTime = CreatedAt.ToShortTimeString();
            Time = time;
        }

        public void AddMessageToList(string message, User user)
        {
            //AllMessages.Add(message);
            DateTime messageTime = DateTime.Now;
            Message newMessage = new(message, messageTime);
        }

        public void DisplayAllMessages(User user)
        {
            string shortTime = CreatedAt.ToShortTimeString();
            foreach (var message in AllMessages)
            {
                Console.WriteLine($"{user.Name} at {shortTime}: {message}");
            }
        }
    }
}
