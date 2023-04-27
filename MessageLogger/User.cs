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

        public void LogIn(User user)
        {
            isLoggedIn = true;
            var name = user.Name;
            var username = user.UserName;
            user = new(name, username);
        }

        public void LogOut(User user)
        {
            isLoggedIn = false;
            var name = "";
            var username = "";
            user = new(name, username);
        }

        public void AddMessage(Message message)
        {
            UserMessages.Add(message);
        }
    }
}
