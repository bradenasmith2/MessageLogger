using System;
using System.Collections.Generic;

namespace MessageLogger
{
    public class User
    {
        public string UserName;
        public string Name;
        public List<Message> UserMessages;
        public bool isLoggedIn;
        public List<User> Users;//move

        public User(string name, string userName)
        {
            UserName = userName;
            Name = name;
            UserMessages = new List<Message>();
            isLoggedIn = false;
            Users = new List<User>();//move to program.cs
        }

        public void InitialProfileCreation()
        {
            Console.WriteLine("Let's create a user profile for you.");
            Console.WriteLine("What is your name? "); var name = Console.ReadLine();
            Console.WriteLine("What would you like your username to be? "); var userName = Console.ReadLine();
            this.Name = name;
            this.UserName = userName;
            this.UserMessages = new List<Message>();

            Users.Add(this);

            Console.WriteLine("To log out of your profile, enter 'log out'.\nTo quit the application, enter 'quit' \nOtherwise type your first message!");
        }

        public void LogIn(string userName)
        {
            isLoggedIn = true;
        }

        public void LogOut(string userName)
        {
            isLoggedIn = false;
        }

        public void AddMessage(Message message)//new method
        {
            UserMessages.Add(message);
        }

        public void AddUserToListOfUsers(User user)//updated method
        {
           Users.Add(user);
        }
    }
}
