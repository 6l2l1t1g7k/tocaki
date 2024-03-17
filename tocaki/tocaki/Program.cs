using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Text;
using tocaki.a1_Helpers;
using tocaki.a3_ErrorsHandler;
using tocaki.a4_DictionaryHolder;
using tocaki.a4_DictionnaryHolder.Dictionnary.a1;
using static System.Runtime.InteropServices.JavaScript.JSType;

bool exit = false;
string userInput;
Console.OutputEncoding = System.Text.Encoding.UTF8;

// TODO remmetre le tri fusion sur des listes texte mais à vocation plus générale
// TODO créer une méthode qui mélange un liste C#

Console.WriteLine("Commande \"help\" ou \"1\" pour afficher le manuel.");

while (!exit) {
    Console.WriteLine();
    Console.Write("Commande: ");
    userInput = Console.ReadLine() ?? string.Empty;

    string[] parameters = userInput.Split(' ');
    string command = string.Empty;
    if (parameters.Length > 0) {
        command = parameters[0];
    }

    // penser à renseigner le fichier d'aide pour les commandes
    switch (command) {
        case "0":
        case "exit":
            exit = true;
            break;
        case "1":
        case "help":
            Tools.DisplayHelp();
            break;
        case "2":
            Console.Write("Text tocaki : ");
            userInput = Console.ReadLine() ?? string.Empty;
            Console.WriteLine("Transcription :");
            Console.WriteLine(Tools.TocakiToFrench(userInput));
            break;
        case "3":
            Console.Write("Text français : ");
            userInput = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(Tools.FrenchToTocaki(userInput));
            break;
        case "4":
            Tools.GenerateRandomNewWords(parameters);
            break;
        case "5":
            if (parameters.Length > 1) {
                LexicalToken? wordToken = Tools.GetTocakiWord(parameters[1]);
                if (wordToken == null) {
                    Console.WriteLine("Mot non trouvé.");
                } else {
                    Console.WriteLine(wordToken.PropertiesToString());
                }
            } else {
                Console.WriteLine("Il manque un mot en paramètre.");
            }
            break;
        case "6":
            if (parameters.Length > 1) {
                List<LexicalToken> wordTokens = Tools.LookForFrenchWord(parameters[1]);
                if (wordTokens.Count == 0) {
                    Console.WriteLine("Aucun mot trouvé.");
                } else {
                    foreach (LexicalToken word in wordTokens) {
                        Console.WriteLine(word.PropertiesToString());
                    }
                }
            } else {
                Console.WriteLine("Il manque un mot en paramètre.");
            }
            break;
        case "7":
            if (parameters.Length < 2) {
                Console.WriteLine("Il manque un mot en paramètre.");
                break;
            }

            // TODO Q? il vaut faire plein de console.writeline ou un seul avec un grosse chaine ? On s'en fou en fait j'imagine ?
            Console.WriteLine($"                         verbe : {parameters[1]}de");
            Console.WriteLine($"                       adverbe : {parameters[1]}ga");
            Console.WriteLine($"                      adjectif : {parameters[1]}me");
            Console.WriteLine($"   complément générique direct : {parameters[1]}si");
            Console.WriteLine($"complément générique indirecte : {parameters[1]}sE");
            break;
        case "8":
            Tools.MergeSort(parameters);
            break;
        default:
            Console.WriteLine("Commande non reconnue.");
            break;
    }
}

