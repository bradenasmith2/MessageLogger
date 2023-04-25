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

        public Message(string content, DateTime time)
        {
            Content = content;
            AllMessages = new List<string>();
            shortTime = CreatedAt.ToShortTimeString();
            CreatedAt = time;
        }

        public void AddMessageToList(Message message)//this needs to add Message to List<Message>
        {

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
