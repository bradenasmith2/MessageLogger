using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection.Metadata;

namespace MessageLogger
{
    public class Message
    {
        //public string Content;
        //public DateTime CreatedAt;
        //public List<string> AllMessages;
        Dictionary<string, DateTime> MessageAndTime = new Dictionary<string, DateTime>();

        public Message(string content, DateTime dateTime)
        {
            MessageAndTime = new Dictionary<string, DateTime> { {content, dateTime } };
        }

        public void AddMessageToDictionary(string message, DateTime date)
        {
            Console.WriteLine("\nAdd a message (or 'quit' to exit): \n");
            MessageAndTime.Add(message, date);
        }

        public void DisplayAllMessages()
        {
            foreach (KeyValuePair<string, DateTime> kvp in MessageAndTime)
            {
                var value = kvp.Value.ToString();
                var key = kvp.Key.ToString();

                Console.WriteLine($"{value}: {key}");
            }
        }
    }
}
