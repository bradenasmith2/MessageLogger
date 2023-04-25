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

        public User(string name, string userName)
        {
            UserName = userName;
            Name = name;
            UserMessages = new List<Message>();
            isLoggedIn = false;
        }

        public void LogIn(string userName)
        {
            isLoggedIn = true;
        }

        public void LogOut(string userName)
        {
            isLoggedIn = false;
        }

        public void AddMessage(Message message)
        {
            UserMessages.Add(message);
        }
    }
}
