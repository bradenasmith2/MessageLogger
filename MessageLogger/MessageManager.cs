using System;
using System.Collections.Generic;

namespace MessageLogger
{
    public class MessageManager
    {
        public List<User> UsersList;

        public MessageManager(List<User> users)
        {
            UsersList = users;
        }

        public void ListAllMessages()//nonfunctioning.. --> displays user.username(first user only) with NO message. (CreatedAt is showing).
        {
            foreach (User user in UsersList)
            {
                Console.WriteLine($"{user.UserName}:\n");
                foreach (Message message in user.UserMessages)
                {
                    Console.WriteLine($"{message.CreatedAt.ToShortTimeString()}: {message.Content}");//message.Content not working?
                }
            }
        }

        public void ListRecentMessages(User user,int num)
        {
            int count = 0;
            for (int i = user.UserMessages.Count - 1; i >= 0; i--)
            {
                if (count == num)
                {
                    break;
                }
                Console.WriteLine($"{user.UserName} at {user.UserMessages[i].CreatedAt.ToShortTimeString()}: {user.UserMessages[i].Content}");
                count++;
            }
        }

        public void ListOfCommands()
        {
            Console.WriteLine("\nAt any time, you can:");
            Console.WriteLine("\n   Type 'quit' to exit the program.");
            Console.WriteLine("\n   Type 'log out' to log out of your current profile.");
            Console.WriteLine("\n   Type 'list' to see a list of all messages and users.");
            Console.WriteLine("\n   Type 'delete' to remove your last message.");
            Console.WriteLine("\n   Type 'recent' to show recent messages prompt.");
            Console.WriteLine("\n   Type 'commands' to see this list again.");
        }

        public void RemoveCommandFromMessages(Message message)
        {
            var lastMessage = message.AllMessages.Last();

            if (lastMessage == "commands")
            {
                message.AllMessages.Remove(lastMessage);
            }

            else if(lastMessage == "list")
            {
                message.AllMessages.Remove(lastMessage);
            }

            else if (lastMessage == "delete")
            {
                message.AllMessages.Remove(lastMessage);
            }

            else if (lastMessage == "quit")
            {
                message.AllMessages.Remove(lastMessage);
            }

            else if (lastMessage == "log out")
            {
                message.AllMessages.Remove(lastMessage);
            }

            else if (lastMessage == "recent")
            {
                message.AllMessages.Remove(lastMessage);
            }
        }
    }
}
