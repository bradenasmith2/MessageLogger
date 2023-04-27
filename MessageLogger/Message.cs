using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;
using System.Xml.Linq;

namespace MessageLogger
{
    public class Message
    {
        public string Content;
        public DateTime CreatedAt;
        public List<string> AllMessages;

        public Message(string content, DateTime time)
        {
            Content = content;
            AllMessages = new List<string>();
            CreatedAt = time;
        }

        public void AddMessageToListString(string message)
        {
            AllMessages.Add(message);
        }

        public void DisplayAllMessages(User user)
        {
            string shortTime = CreatedAt.ToShortTimeString();
            foreach (var message in AllMessages)
            {
                Console.WriteLine($"{user.Name} at {shortTime}: {message}"); //<<--- this "message" is unrelated to the passed in user.
            }
        }

        //public void DisplayAllMessages(User user)
        //{
        //    foreach (Message message in user.UserMessages)
        //    {
        //        Console.WriteLine($"{user.Name}: {message.Content}");
        //    }
        //}
    }
}
