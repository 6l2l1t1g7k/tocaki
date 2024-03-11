using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
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
        string namespaceName = typeof(Tools).Namespace ?? throw new ApplicationException($"{ErrorsEnum.Er0001} : Namespace inconnue."); // TODO Q? c'est bien comme ça pour les erreurs ?
        string internalPath = namespaceName[(_lengthOfProjectName + 1)..].Replace(".", "\\") + "\\Help Instructions.txt"; // TODO Q? c'est un peu tordu mais j'ai pas trouvé mieux pour faire un truc pseudo dynamique
        string filePath = Path.Combine(basePath, internalPath);

        try {
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        } catch (IOException e) {
            Console.WriteLine("Erreur de lecture du fichier d'aide.");
            Console.WriteLine(e.Message);
        } // TODO Q? comment faire pour que les fichiers de ressources fasse partie du projet compilé ?
    }

    /// <summary>
    /// La méthode est approximative.
    /// </summary>
    /// <param name="textInput"></param>
    /// <returns></returns>
    public static string TocakiToFrench(string textInput) {
        // Utilise Regex pour remplacer chaque occurrence selon les paires définies dans le dictionnaire
        string temp = string.Join("|", _replacementsTocakiToFrench.Keys.Select(Regex.Escape)); // TODO refactoriser dans l'appel de méthode dessous une fois que c'est compris
        string resultString = Regex.Replace(textInput, temp, m => _replacementsTocakiToFrench[m.Value]); // TODO Q? ça fait quoi cette ligne gpt ?

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
            foreach(string word in token.FrenchWordsAssociated) {
                if (word.Contains(userInput)) {
                    Result.Add(token);
                }
            }
        }

        return Result;
    }
}
