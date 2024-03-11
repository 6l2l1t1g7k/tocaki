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
Random rnd = new();
Console.OutputEncoding = System.Text.Encoding.UTF8;


// TODO Q ? ici : cd "D:\01_kla\01_Hti elemAtGr pGRsonGl\1_tocaki\tocaki\tocaki\a10_Build du 11;03;2024" 
// .\tocaki.exe
// pk j'ai ça ? : Failed to create CoreCLR, HRESULT: 0x80070057

// TODO être capable de générer le fichier du dictionnaire à partir du programme pour la visualisation ?
// TODO Q? réfléchir à :
//      - la pertinence d'une base de donné
// TODO Q? windows n'est pas sensible à la casse pour les noms de fichiers, j'ai envie de tuer certains humains
// TODO Q? comment je gère les names spaces qui ne sont plus consistant avec les dossiers ?
// plutôt garder les namespaces logique ou créer un namespace dédier à chaque fois pour garder la cohérence avec les dossiers ? (a priori on voudrais les namespace, mais 
// 1 ça va faire exploser leur nombre
// 2 ça va rendre non régulier leur utilisation, parfois les fichiers en feuille de l'arbre seront plus bas que d'autre

// TODO lister les jetons phonétiques disponibles

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
            // La méthode n'est pas optimal, c'est un peu chaotique la façon dont ça procède
            if (parameters.Length < 3) {
                Console.WriteLine("Il manque un type en paramètre, par exemple \"232 10\".");
                break;
            }

            List<int> intList = [];
            int numberOfProposals;
            try {
                foreach (char c in parameters[1]) {
                    intList.Add(int.Parse(c.ToString()));
                }
                numberOfProposals = int.Parse(parameters[2]);
            } catch {
                Console.WriteLine("Problème dans les paramètres à priori.");
                break;
            }

            // Chargement de l'alphabet tocaki
            char[] consonantList;
            char[] vowelList;

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string internalPath = "a4_DictionnaryHolder\\Ressources logicielles\\7_flagla(tocaki).txt";
            string filePath = Path.Combine(basePath, internalPath);

            try {
                using StreamReader sr = new(filePath);
                consonantList = sr.ReadLine()!.ToCharArray();
                vowelList = sr.ReadLine()!.ToCharArray();
            } catch (Exception e) {
                Console.WriteLine("Erreur de lecture du fichier de l'alphabet.");
                Console.WriteLine(e.Message);
                break;
            }

            int maxTry = 1000;
            int counter = 0;
            bool ok;
            string[] listOfProposals = new string[numberOfProposals];
            int randomNumber;
            StringBuilder proposal = new();
            StringBuilder syllabe;
            LexicalToken? tocakiToken;
            for (int generationIndex = 0; generationIndex < numberOfProposals; generationIndex++) {
                ok = false;
                while (!ok && counter < maxTry) {
                    proposal = new();
                    ok = true;

                    // Construction de la première syllabe aléatoire
                    syllabe = new();
                    for (int i = 1; i < intList[0]; i++) {
                        randomNumber = rnd.Next(0, consonantList.Length);
                        syllabe.Append(consonantList[randomNumber]);
                    }
                    randomNumber = rnd.Next(0, vowelList.Length);
                    syllabe.Append(vowelList[randomNumber]);

                    // Vérification de la validité de la syllabe
                    tocakiToken = Tools.GetTocakiWord(syllabe.ToString());
                    if (tocakiToken != null) {
                        if (tocakiToken.DefinitionInTocaki != "reglu-[]") {
                            ok = false;
                            continue;
                        }
                    }
                    proposal.Append(syllabe);

                    // Construction de la suite du mot aléatoire
                    for (int index = 1; index < intList.Count; index++) {
                        // Construction d'une syllabe
                        syllabe = new();
                        for (int i = 1; i < intList[index]; i++) {
                            randomNumber = rnd.Next(0, consonantList.Length);
                            syllabe.Append(consonantList[randomNumber]);
                        }
                        randomNumber = rnd.Next(0, vowelList.Length);
                        syllabe.Append(vowelList[randomNumber]);

                        // Vérification de la validité de la syllabe
                        tocakiToken = Tools.GetTocakiWord(syllabe.ToString());
                        if (tocakiToken != null) {
                            if (tocakiToken.DefinitionInTocaki != "[]-vuma-*") {
                                ok = false;
                                break;
                            }
                        }
                        proposal.Append(syllabe);
                    }
                    counter++;
                }

                if (ok) {
                    listOfProposals[generationIndex] = proposal.ToString();
                    continue;
                }

                listOfProposals[generationIndex] = $"Après {counter} essaies rien n'a été trouvé.";
            }

            foreach (string word in listOfProposals) {
                Console.WriteLine(word);
            }

            // TODO Q? c'est quoi ce machin de GPT  (dans le if) ?
            //static void Main() {
            //    string input = "232";
            //    List<int> numbers = new List<int>();

            //    foreach (char c in input) {
            //        if (int.TryParse(c.ToString(), out int number)) {
            //            numbers.Add(number);
            //        }
            //    }

            //    // Affichage des nombres pour vérifier
            //    foreach (int number in numbers) {
            //        Console.WriteLine(number);
            //    }
            //}
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
        default:
            Console.WriteLine("Commande non reconnue.");
            break;
    }
}

