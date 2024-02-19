bool exit = false;
string userInput;

while (!exit)
{
    Console.WriteLine("");

    Console.Write("Commande:");
    userInput = Console.ReadLine() ?? string.Empty;

    switch (userInput)
    {
        case "0":
            exit = true;
            break;
        case "exit":
            exit = true;
            break;
        default:
            Console.WriteLine("Commande non reconnue.");
            break;
    }
}

