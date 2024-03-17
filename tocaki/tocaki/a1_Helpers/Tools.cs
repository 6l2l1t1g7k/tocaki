using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using tocaki.a1_Helpers;
using tocaki.a3_ErrorsHandler;
using tocaki.a4_DictionaryHolder;
using tocaki.a4_DictionnaryHolder.Dictionnary.a222;

namespace tocaki.a1_Helpers;

public static class Tools {
    private static readonly string _projectName = "tocaki";
    private static readonly int _lengthOfProjectName = _projectName.Length; // Asctuce pour supprimer juste les premiers caractères

    private static readonly List<LexicalToken> _dictionnary = [];
    private static readonly object _treadSafeLoker = new();

    private static readonly Dictionary<string, string> _replacementsTocakiToFrench = new()
        {
            { "£", "e" },
            { "E", "eu" },
            { "L", "eu" },
            { "e", "é" },
            { "G", "ai" },
            { "M", "on" },
            { "N", "in" },
            { "A", "an" },
            { "µ", "un" },
            { "D", "au" },
            { "H", "ou" },
            { "T", "th" },
            { "c", "l" },
            { "€", "sh" },
            { "q", "ch" },
            { "R", "r" },
            { "Q", "r" },
            { "ç", "r" },
            { "F", "th" },
            { "z", "s" },
            { "w", "oi" },
            { "B", "u" },
            { "&", "r" },
            { "$", "gn" },
        };

    private static readonly Dictionary<string, string> _replacementsFrenchToTocaki = new()
    {
            { "eu", "E" },
            { "e", "E" },
            { "é", "e" },
            { "ai", "G" },
            { "on", "M" },
            { "in", "N" },
            { "an", "A" },
            { "en", "A" },
            { "em", "A" },
            { "am", "A" },
            { "un", "µ" },
            { "D", "au" },
            { "H", "ou" },
            { "T", "th" },
            { "qu", "k" },
            { "ch", "q" },
            { "x", "ks" },
            { "oi", "w" },
            { "gn", "$" },
        };

    public static void DisplayHelp() {
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string namespaceName = typeof(Tools).Namespace ?? throw new GeneralException(ErrorsEnum.Err0001);
        string internalPath = namespaceName[(_lengthOfProjectName + 1)..].Replace(".", "\\") + "\\Help Instructions.txt";
        string filePath = Path.Combine(basePath, internalPath);

        try {
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        } catch (IOException e) {
            Console.WriteLine("Erreur de lecture du fichier d'aide.");
            Console.WriteLine(e.Message);
        }
    }

    /// <summary>
    /// La méthode est approximative.
    /// </summary>
    /// <param name="textInput"></param>
    /// <returns></returns>
    public static string TocakiToFrench(string textInput) {
        // Utilise Regex pour remplacer chaque occurrence selon les paires définies dans le dictionnaire
        string temp = string.Join("|", _replacementsTocakiToFrench.Keys.Select(Regex.Escape)); // TODO refactoriser dans l'appel de méthode dessous une fois que c'est compris
        string resultString = Regex.Replace(textInput, temp, m => _replacementsTocakiToFrench[m.Value]);

        return resultString;
        // TODO utiliser chagpt pour passer en bon français
    }

    /// <summary>
    /// La méthode est très approximative.
    /// </summary>
    /// <param name="textInput"></param>
    /// <returns></returns>
    public static string FrenchToTocaki(string textInput) {
        // Utilise Regex pour remplacer chaque occurrence selon les paires définies dans le dictionnaire
        string temp = string.Join("|", _replacementsFrenchToTocaki.Keys.Select(Regex.Escape));
        string resultString = Regex.Replace(textInput, temp, m => _replacementsFrenchToTocaki[m.Value]);

        return resultString;
    }

    /// <summary>
    /// </summary>
    /// <param name="userInput"></param>
    /// <returns>Le mot demander sinon null.</returns>
    public static LexicalToken? GetTocakiWord(string userInput) // TODO Q? quelle est la bonne façon pour aller chercher un objet ? Une factory mais ?
    {
        InitializeDictionaryIdNeeded();

        foreach (LexicalToken token in _dictionnary) {
            if (token.Phonetics == userInput) {
                return token;
            }
        }

        return null;
    }

    /// <summary>
    /// Crée une instance pour chaque classe des <see cref="LexicalToken"/> tocaki.
    /// </summary>
    private static void InitializeDictionaryIdNeeded() { // TODO Q? ça m'a l'air mieux dedans que dehors le test du IfNeeded
        lock (_treadSafeLoker) {
            if (_dictionnary.Count != 0) {
                return;
            }

            Console.WriteLine("Intialisation du dictionnaire...");
            Stopwatch stopwatch = new();
            stopwatch.Start();

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type[] types = assembly.GetTypes();

            foreach (Type type in types) {
                if (type.Namespace != null && type.Namespace.StartsWith("tocaki.a4_DictionnaryHolder.Dictionnary")) { // TODO on peut faire autrement pour garantir la non nullité ?
                    LexicalToken instance = (LexicalToken)(Activator.CreateInstance(type) ?? new Token_tocaki());
                    _dictionnary!.Add(instance);
                }
            }

            stopwatch.Stop();
            long elapsedSeconds = stopwatch.ElapsedMilliseconds / 1000;
            Console.WriteLine($"Fin de l'initialisation du dictionnaire. Durée du chargement : {elapsedSeconds}s");
        }
    }

    public static List<LexicalToken> LookForFrenchWord(string userInput) {
        InitializeDictionaryIdNeeded();
        List<LexicalToken> Result = [];

        foreach (LexicalToken token in _dictionnary) {
            foreach (string word in token.FrenchWordsAssociated) {
                if (word.Contains(userInput)) {
                    Result.Add(token);
                }
            }
        }

        return Result;
    }

    /// <summary>
    /// La méthode gère les affichages console en cas d'erreurs de paramètre.
    /// </summary>
    /// <param name="parameters"></param>
    public static void GenerateRandomNewWords(string[] parameters) {
        // La méthode n'est pas optimal, c'est un peu chaotique la façon dont ça procède
        if (parameters.Length < 3) {
            Console.WriteLine("Il manque un type en paramètre, par exemple \"232 10\".");
            return;
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
            return;
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
            return;
        }

        int maxTry = 1000;
        int counter = 0;
        bool ok;
        string[] listOfProposals = new string[numberOfProposals];
        int randomNumber;
        Random rnd = new();
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
    }

    // TODO voir pour créer une fonction de comparaison à donner à un tri standard C#
    // "En C# comment faire pour créer une fonction de comparaison custom que je donne ensuite à un algorithme de tri pour me trier une liste spéciale ?"
    // TODO rendre ce tri générique sur des objets printable, remplacer string par object comparable ou un truc du genre
    // L'utilisation de la mémoire est mauvaise, les listes ne serront pas désindexé avant le passage du ramasse miette
    /// <summary>
    /// Tri fusion qui demande un classement du plus grand au plus petit.
    /// </summary>
    /// <param name="parameters"></param>
    public static void MergeSort(string[] parameters) {
        if (parameters.Length < 2) {
            Console.WriteLine("Il manque l'url d'un fichier texte en paramètre.");
            return;
        }

        string[] data;
        try {
            // Lit toutes les lignes du fichier et les stocke dans un tableau
            data = File.ReadAllLines(parameters[1]);

            // Affiche chaque ligne du tableau
            Console.WriteLine("--- Données chargées : ---");
            foreach (string ligne in data) {
                Console.WriteLine(ligne); // TODO retirer l'affichage
            }
        } catch (IOException e) {
            Console.WriteLine("Une erreur s'est produite lors de la lecture du fichier.");
            Console.WriteLine(e.Message);
            return;
        }

        Console.WriteLine();
        Console.WriteLine("--- Début du tri fusion ---");
        Console.WriteLine("Écrire 1 ou 2 pour choisir l'item le plus grand lors des questions.");
        // Initialisation des listes
        List<List<string>> workSpace = [];

        foreach (string item in data) {
            workSpace.Add([item]);
        }

        // Fusion des listes
        while (workSpace.Count > 1) {
            List<List<string>> tempWorkSpace = [];
            for (int i = 0; i < workSpace.Count - 1; i += 2) {
                tempWorkSpace.Add(Merge2Lists(workSpace[i], workSpace[i + 1]));
            }
            if (workSpace.Count % 2 == 1) {
                tempWorkSpace.Add(workSpace.Last());
            }
            workSpace = tempWorkSpace;
        }

        Console.WriteLine("--- Fin du tri fusion ---");
        foreach (string ligne in workSpace[0]) {
            Console.WriteLine(ligne);
        }

        Console.WriteLine("Veux tu créer un fichier avec la liste trié ? (y/n)");
        bool ok = false;
        while (!ok) {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine();
            if (key.Key == ConsoleKey.Y) {
                File.WriteAllLines(parameters[1] + " (trié).txt", workSpace[0]);
                Console.WriteLine("Fichier créé.");
                ok = true;
            } else if (key.Key == ConsoleKey.N) {
                Console.WriteLine("Fichier non créé.");
                ok = true;
            } else {
                Console.WriteLine("Commande non reconnue.");
            }
        }
    }

    /// <summary>
    /// Fusion de 2 listes par l'utilisateur pour un tri fusion.
    /// </summary>
    /// <param name="list1"></param>
    /// <param name="list2"></param>
    /// <returns></returns>
    private static List<string> Merge2Lists(List<string> list1, List<string> list2) {
        List<string> resultList = [];
        ConsoleKeyInfo key;
        string item1 = list1[0];
        string item2 = list2[0];
        while (list1.Count > 0 && list2.Count > 0) {
            bool ok = false;
            while (!ok) {
                Console.WriteLine("Quel est le plus grand entre :");
                Console.WriteLine($"1 : {item1}");
                Console.WriteLine($"2 : {item2}");
                key = Console.ReadKey();
                Console.WriteLine();
                if (key.Key == ConsoleKey.NumPad1) {
                    resultList.Add(item1);
                    list1.RemoveAt(0);
                    if (list1.Count > 0) {
                        item1 = list1[0];
                    }
                    ok = true;
                } else if (key.Key == ConsoleKey.NumPad2) {
                    resultList.Add(item2);
                    list2.RemoveAt(0);
                    if (list2.Count > 0) {
                        item2 = list2[0];
                    }
                    ok = true;
                } else {
                    Console.WriteLine("Commande invalide.");
                }
            }
        }

        if (list1.Count > 0) {
            foreach (string item in list1) {
                resultList.Add(item);
            }
        } else if (list2.Count > 0) {
            foreach (string item in list2) {
                resultList.Add(item);
            }
        }

        return resultList;
    }

    /// <summary>
    /// Le mélange se fait sur la liste passé en paramètre.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="InputList"></param>
    /// <returns></returns>
    public static void ShuffleList<T>(List<T> InputList) {
        Random rng = new();
        for (int n = InputList.Count - 1; n > 0; n--) {
            int k = rng.Next(n + 1);
            (InputList[n], InputList[k]) = (InputList[k], InputList[n]);
        }
    }
}
