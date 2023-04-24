using MessageLogger;

Console.WriteLine("Welcome to Message Logger!");
User user1 = new("", "");
Message message1 = new("", DateTime.Now);

user1.InitialProfileCreation();
while (message1)
{
    message1.AddMessageToDictionary(Console.ReadLine(), DateTime.Now);
    message1.DisplayAllMessages();
}
