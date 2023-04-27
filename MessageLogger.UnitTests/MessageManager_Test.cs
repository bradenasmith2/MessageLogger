using System;
using System.Collections.Generic;

namespace MessageLogger.UnitTests
{
    public class MessageManager_Test
    {
        [Fact]
        public void MessageManger_Constructor_SetsValuesCorrectly()
        {
            List<User> usersTest = new List<User>();
            MessageManager mM = new(usersTest);

            Assert.Equal(usersTest, mM.UsersList);//these variables are identical, does this accurately test?

            List<User> users1 = new List<User>();
            Assert.Equal(users1, mM.UsersList);

        }

        [Fact]
        public void MessageManager_()
        {

        }
    }
}
