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

            Assert.Equal(ShortTime.ToShortTimeString(), message1.shortTime);//time
            Assert.Equal("this is a message.", message1.Content);//message
            Assert.Equal(list, message1.AllMessages);//list

        }

        [Fact]
        public void Message_AddMessage_AddsGivenMessageToList_AllMessages()
        {
            Message message1 = new("this is a message.");
            message1.AddMessageToList("this is a second message");
            message1.AddMessageToList(message1.Content);

            Assert.Equal("this is a message.", message1.AllMessages[1]);
            Assert.Equal("this is a second message", message1.AllMessages[0]);
        }

        [Fact]
        public void Message_DisplayMessage_PrintsAllMessageInListWithCorrectTime()
        {
            Message message1 = new("this is a message.");//message 1 instantiated
            message1.AddMessageToList(message1.Content);//adding message 1
            message1.AddMessageToList("this is a second message");//adding message 2
            DateTime shortTime = DateTime.Now;
            shortTime.ToShortTimeString();

            Assert.Equal("this is a message.", message1.AllMessages[0]);
            Assert.Equal("this is a second message", message1.AllMessages[1]);
            Assert.Equal(shortTime.ToShortTimeString(), message1.shortTime);//double conversion of shortTime ToShortTime

        }
    }
}