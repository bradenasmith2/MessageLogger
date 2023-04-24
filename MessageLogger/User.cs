using System;
using System.Collections.Generic;

namespace MessageLogger
{
    public class User
    {
        public string UserName;
        public string Name;
        public List<Message> UserMessages;

        public User(string name, string userName)
        {
            UserName = userName;
            Name = name;
            UserMessages = new List<Message>();
        }

        public void InitialProfileCreation()
        {
            Console.WriteLine("What is your name? "); Name = Console.ReadLine();
            Console.WriteLine("What would you like your username to be? "); UserName = Console.ReadLine();

            Console.WriteLine("To log out of your profile, enter 'log out'.\nTo quit the application, enter 'quit' \nOtherwise type your first message!");
        }
    }
}
