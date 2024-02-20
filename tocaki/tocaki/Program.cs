using tocaki.a1_Helpers;
using tocaki.a4_Dictionnary.a1;

bool exit = false;
string userInput;
string textInput;

Console.WriteLine("Commande \"help\" pour l'aide.");

while (!exit)
{
    Console.Write("Commande: ");
    userInput = Console.ReadLine() ?? string.Empty;

    // penser à renseigner le fichier d'aide pour les commandes
    switch (userInput)
    {
        case "0":
        case "exit":
            exit = true;
            break;
        case "1":
        case "help":
            Tools.DisplayHelp();
            break;
        case "2":
        case "to vers fr":
        case "tocaki vers français":
            Console.Write("Text tocaki : ");
            textInput = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(Tools.TocakiToFrench(textInput));
            break;
        case "3":
        case "fr to to":
        case "français vers tocaki":
            Console.Write("Text français : ");
            textInput = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(Tools.FrenchToTocaki(textInput));
            break;
        case "4":
            Token_o token = new();
            Console.WriteLine(token.PropertiesToString());
            break;
        default:
            Console.WriteLine("Commande non reconnue.");
            break;
    }
}



