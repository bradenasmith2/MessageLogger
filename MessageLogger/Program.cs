using MessageLogger;

Console.WriteLine("Welcome to Message Logger!\nLet's create a user profile for you.\nWhat is your name?"); var name = Console.ReadLine();
Console.WriteLine("What would you like your username to be?"); var username = Console.ReadLine();

Message message = new("",DateTime.Now);

User user = new(name, username);

var Users = new List<User>();

string userMessage = "";

while (userMessage != "quit")
{
    userMessage = "";

    while (userMessage != "log out")
    {
        Console.WriteLine("\nAdd a message (or 'quit' to exit): \n");
        userMessage = Console.ReadLine();                                                 //step 1
        message.AllMessages.Add(userMessage);//list of strings that contains Content        step 3
        user.AddMessage(message);//adds message(type Message) to list of <Message>          step 5
        

        if (userMessage == "log out")
        {
            break;
        }

        else if (userMessage == "quit")
        {
            Console.WriteLine("Quitting...");
            break;
        }

        user.AddMessage(message);
        //Users.Add(user);

        Console.WriteLine("Your previous logs:");

        message.DisplayAllMessages(user);
    }

    if (userMessage == "quit")
    {
        break;
        //remove last index in list, as "quit" is added as a message. Same with "log out".
    }

    Console.WriteLine("Logging out...");
    //foreach here for this code below.
    Console.WriteLine($"{user.UserName} wrote {message.AllMessages.Count} messages.");
    Console.Write("Would you like to log in a 'new' or 'existing' user? "); 
    var response = Console.ReadLine();

    if (response == "new")
    {
        Console.WriteLine("Welcome to Message Logger!\nLet's create a user profile for you.\nWhat is your name?"); name = Console.ReadLine();
        Console.WriteLine("What would you like your username to be?"); username = Console.ReadLine();
        user = new(name, username);
    }

    else if (response == "existing")
    {
        Console.WriteLine("What is your username? "); var user1 = Console.ReadLine();
        user.LogIn(user1);
    }

    else
    {
        Console.WriteLine("Invalid response.");
    }
    Users.Add(user);//adds user(type User) to list of <User>                            step 4
}

Console.WriteLine("Thank you for using Message Logger!");

foreach (User user2 in Users)
{
    int messageCount = 0;
    foreach (Message message2 in user.UserMessages)
    {
        messageCount++;
    }
    Console.WriteLine($"{user.Name} has entered {messageCount} messages.");//this does not use multiple User's names.
}
