namespace MessageLogger.UnitTests
{
    public class Message_Test
    {
        [Fact]
        public void Message_Constructor_SetsValuesCorrectly()
        {
            Message message1 = new("this is a message.", DateTime.Now);

            Assert.Equal("this is a message.", message1.Content);
        }

        [Fact]
        public void Message_AddMessage_AddsGivenMessageToList_AllMessages()
        {
            Message message1 = new("this is a message.", DateTime.Now);

            message1.AddMessage(message1.Content, DateTime.Now);

            Assert.Equal("this is a message.", message1.AllMessages[0]);
        }

        [Fact]
        public void Message_DisplayMessage_PrintsLastMessageInList()
        {
            Message message1 = new("this is a message.", DateTime.Now);
            Message message2 = new("this is a second message", DateTime.Now);
            Message message3 = new("this is a third message.", DateTime.Now);

            message1.AddMessage(message1.Content, DateTime.Now);
            message2.AddMessage(message2.Content, DateTime.Now);
            message3.AddMessage(message3.Content, DateTime.Now);

            Assert.Equal("this is a third message.", message3.AllMessages.Last());

        }
    }
}