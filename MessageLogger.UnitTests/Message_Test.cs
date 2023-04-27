namespace MessageLogger.UnitTests
{
    public class Message_Test
    {
        [Fact]
        public void Message_Constructor_SetsValuesCorrectly()
        {
            Message message1 = new("this is a message.");
            var ShortTime = DateTime.Now;
            ShortTime.ToShortTimeString();
            List<string> list = new List<string>();

            Assert.Equal(ShortTime.ToShortTimeString(), message1.CreatedAt.ToShortTimeString());
            Assert.Equal("this is a message.", message1.Content);
            Assert.Equal(list, message1.AllMessages);

        }

        [Fact]
        public void Message_AddMessageToListString_AddsGivenMessageToList_AllMessages()
        {
            Message message1 = new("this is a message.");
            message1.AddMessageToListString("this is a second message");
            message1.AddMessageToListString(message1.Content);

            Assert.Equal("this is a message.", message1.AllMessages[1]);
            Assert.Equal("this is a second message", message1.AllMessages[0]);
        }

        [Fact]
        public void Message_DisplayAllMessages_PrintsAllMessageInList()
        {
            User user1 = new("John", "johndoe123");
            Message message1 = new("this is a message.");
            var shortTime = DateTime.Now.ToShortTimeString();

            message1.AddMessageToListString(message1.Content);
            user1.AddMessage(message1);

            Assert.Equal("John", user1.Name);
            Assert.Equal(shortTime, message1.CreatedAt.ToShortTimeString());
            Assert.Equal(message1.Content, message1.AllMessages[0]);

        }
    }
}