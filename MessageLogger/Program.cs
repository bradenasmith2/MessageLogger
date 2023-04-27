using MessageLogger;
using System.Runtime.Intrinsics.X86;

Console.Write("Welcome to Message Logger!\nLet's create a user profile for you.\n\nWhat is your name? ");
var name = Console.ReadLine();
Console.Write("What would you like your username to be? ");
var username = Console.ReadLine();

var Users = new List<User>();
MessageManager messageManager = new(Users);
messageManager.ListOfCommands();

string userMessage = "";

while (userMessage != "quit")
{
    User user = new(name, username);
    Message message = new(userMessage, DateTime.Now);
    userMessage = "";

    while (userMessage != "log out")
    {
        Console.WriteLine("\nAdd a message or command: \n");
        userMessage = Console.ReadLine();

        if (userMessage.ToLower() == "log out")
        {
            Console.WriteLine("Logging out...");
            user.LogOut(user);
            break;
        }

        else if (userMessage.ToLower() == "quit")
        {
            Console.WriteLine("Quitting...");
            break;
        }

        else if (userMessage.ToLower() == "list")
        {
            messageManager.ListAllMessages();
        }

        else if (userMessage.ToLower() == "commands")
        {
            messageManager.ListOfCommands();
            continue;//prevents "Your previous logs:" from displaying.

        }

        else if (userMessage.ToLower() == "delete")
        {
            if (message.AllMessages.Count > 0)
            {
                int lastIndex = message.AllMessages.Count - 1;
                message.AllMessages.RemoveAt(lastIndex);
                Console.WriteLine("Most recent message removed.");
            }

            //incomplete and untested 

            //else if (userMessage.ToLower() == "recent")
            //{
            //    Console.Write("How many recent messages would you like to see? ");
            //    var num = Console.ReadLine();
            //    Convert.ToInt32(num);
            //    messageManager.ListRecentMessages(user, num);
            //}

            else
            {
                Console.WriteLine("No messages to remove.");
            }
        }

        Console.WriteLine("Your previous logs:");

        message.AddMessageToListString(userMessage);
        messageManager.RemoveCommandFromMessages(message);

        message.DisplayAllMessages(user);

        user.AddMessage(message);//adds messages, other than 'quit' or 'log out' because of break;
        
    }

    Users.Add(user);

    if (userMessage.ToLower() == "quit")
    {
        break;
    }

    Console.WriteLine($"\n{user.UserName} wrote {message.AllMessages.Count} messages.");
    Console.Write("\nWould you like to log in a 'new' or 'existing' user? ");
    var response = Console.ReadLine();

    if (response.ToLower() == "new")
    {
        Console.Write("\nWelcome to Message Logger!\nLet's create a user profile for you.\n\nWhat is your name? ");
        name = Console.ReadLine();
        Console.Write("What would you like your username to be? ");
        username = Console.ReadLine();
        user = new User(name, username);
    }

    else if (response.ToLower() == "existing")
    {
        Console.Write("What is your name? ");
        var nameInput = Console.ReadLine();
        Console.Write("What is your username? ");
        var userNameInput = Console.ReadLine();

        user = new(nameInput, userNameInput);
        user.LogIn(user);

        Console.WriteLine("\nYour message logs from your previous log in:\n");
        message.DisplayAllMessages(user);
    }

    else
    {
        Console.WriteLine("Invalid response.");
    }
}
Console.WriteLine("Thank you for using Message Logger!");

foreach (User user in Users)
{
    Console.WriteLine($"{user.Name} has entered {user.UserMessages.Count} messages.");
}

/* Log-In method:
 * Needs to reassign properties based on user.UserName 
 * use int i user.UserName[i]???
 * 
 */