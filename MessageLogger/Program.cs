using MessageLogger;

Console.WriteLine("Welcome to Message Logger!\nLet's create a user profile for you.\nWhat is your name?"); var name = Console.ReadLine();
Console.WriteLine("What would you like your username to be?"); var username = Console.ReadLine();

Message message = new("",DateTime.Now);

User user = new(name, username);

string userMessage = "";

while (userMessage != "quit")
{
    userMessage = "";

    while (userMessage != "log out")
    {
        Console.WriteLine("\nAdd a message (or 'quit' to exit): \n");
        userMessage = Console.ReadLine();

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

        Console.WriteLine("Your previous logs:");
        
        message.DisplayAllMessages(user);
    }

    if (userMessage == "quit")
    {
        break;
    }

    Console.WriteLine("Logging out...");
    //foreach here for this code below.
    Console.WriteLine($"{user.UserName} wrote {message.AllMessages.Count} messages.");
    Console.WriteLine("Would you like to log in a 'new' or 'existing' user?"); var response = Console.ReadLine();

    if (response == "new")
    {
        user.InitialProfileCreation();
        user.Users.Add(user);
        user.AddUserToListOfUsers(user);
    }

    else if (response == "existing")
    {
        Console.WriteLine("What is your username? "); var user1 = Console.ReadLine();
        user.LogIn(user1);
    }

    else
    {
        user.InitialProfileCreation();
    }
}

Console.WriteLine("Thank you for using Message Logger!");
foreach (User user2 in user.Users)
{
    Console.WriteLine($"{user2.Name} has entered {user2.UserMessages.Count} messages."); //only displays last .Name, and also only displays 0 Messages. Not getting added? Not called correctly?
}