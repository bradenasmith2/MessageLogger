using System;
using System.Collections.Generic;

namespace MessageLogger.UnitTests
{
    public class User_Test
    {
        [Fact]
        public void User_Constructor_SetsValuesCorrectly()
        {
            User user = new("John", "johndoe123");
            List<Message> emptyList = new List<Message>();

            Assert.Equal("John", user.Name);
            Assert.Equal("johndoe123", user.UserName);
            Assert.False(user.isLoggedIn);
            Assert.Equal(emptyList, user.UserMessages);
        }

        [Fact]
        public void User_LogIn_UsersIsLoggedInSet_True()
        {
            User user = new("John", "johndoe123");
            user.LogIn(user);

            Assert.True(user.isLoggedIn);
        }

        [Fact]
        public void User_LogOut_UsersIsLoggedInSet_False()
        {
            User user = new("John", "johndoe123");

            user.LogIn(user);
            Assert.True(user.isLoggedIn);//Logging in user so IsLoggedIn set true, so this can test if IsLoggedIn updates to false.

            user.LogOut(user);
            Assert.False(user.isLoggedIn);
        }

        [Fact]
        public void User_AddMessage_AddsMessageObjectToUserMessages()
        {
            User user = new("John", "johndoe123");
            Message message = new("this is a message.", DateTime.Now);
            Message message2 = new("this is a second message.", DateTime.Now);

            user.AddMessage(message);
            user.AddMessage(message2);

            Assert.Equal(message, user.UserMessages[0]);
            Assert.Equal(message2, user.UserMessages[1]);
        }
    }
}

//I haven't revisisted Tests in a while.