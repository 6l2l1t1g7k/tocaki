using tocaki.a1_Helpers;
using tocaki.a4_Dictionary;
using tocaki.a4_Dictionary.a1;

bool exit = false;
string userInput;

Console.WriteLine("Commande \"help\" pour l'aide.");

// TODO être capable de générer le fichier du dictionnaire à partir du programme pour la visualisation ?
// TODO réfléchir à :
//      - la pertinence d'une base de donné
// TODO Q? windows n'est pas sensible à la casse pour les noms de fichiers, j'ai envie de tuer certains humains
// voilàààà
// TODO Q? comment je gère les names spaces qui ne sont plus consistant avec les dossiers ? 
// plutôt garder les namespaces logique ou créer un namespace dédier à chaque fois pour garder la cohérence avec les dossiers ? (a priori on voudrais les namespace, mais 
// 1 ça va faire exploser leur nombre
// 2 ça va rendre non régulier leur utilisation, parfois les fichiers en feuille de l'arbre seront plus bas que d'autre

// TODO lister les jetons phonétiques disponibles

// TODO tester le ternaire pour ça :
//x > 12 ? {
//    sfsqsdf;
//    } : {

//}

while (!exit)
{
    Console.WriteLine();
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
            userInput = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Transcription :");
            Console.WriteLine(Tools.TocakiToFrench(userInput));
            break;
        case "3":
        case "fr to to":
        case "français vers tocaki":
            Console.Write("Text français : ");
            userInput = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(Tools.FrenchToTocaki(userInput));
            break;
        case "5":
        case "Traduire tocaki":
            Console.Write("Mot tocaki : ");
            userInput = Console.ReadLine() ?? string.Empty;
            LexicalToken wordToken = Tools.GetTocakiWord(userInput);
            Console.WriteLine(wordToken.PropertiesToString());
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



