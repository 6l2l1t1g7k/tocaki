using System.Reflection;
using System.Text.RegularExpressions;
using tocaki.a3_ErrorsHandler;
using tocaki.a4_DictionaryHolder;
using tocaki.a4_DictionnaryHolder.Dictionnary.a222;

namespace tocaki.a1_Helpers;

public static class Tools {
    private static readonly string _projectName = "tocaki";
    private static readonly int _lengthOfProjectName = _projectName.Length; // Asctuce pour supprimer juste les premiers caractères

    private static readonly List<LexicalToken>? _dictionnary;
    private static readonly object _treadSafeLoker = new();

    private static readonly Dictionary<string, string> _replacements = new()
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
            { "o", "o" },
            { "D", "au" },
            { "H", "ou" },
            { "T", "th" },
            { "k", "k" },
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

    public static void DisplayHelp() {
        string basePath = AppDomain.CurrentDomain.BaseDirectory;
        string namespaceName = typeof(Tools).Namespace ?? throw new ApplicationException($"{ErrorsEnum.Er0001} : Namespace inconnue."); // TODO Q? c'est bien comme ça pour les erreurs ?
        string internalPath = namespaceName[(_lengthOfProjectName + 1)..].Replace(".", "\\") + "\\Help Instructions.txt"; // TODO Q? c'est un peu tordu mais j'ai pas trouvé mieux
        string filePath = Path.Combine(basePath, internalPath);

        try {
            string content = File.ReadAllText(filePath);
            Console.WriteLine(content);
        } catch (IOException e) {
            Console.WriteLine("Erreur de lecture du fichier d'aide.");
            Console.WriteLine(e.Message);
        } // TODO Q? comment faire pour que les fichiers de ressources fasse partie du projet compilé ?
    }

    public static string FrenchToTocaki(string textInput) {
        return "Pas implémenté c'est foireux, c'est pas déterministe ou pas facilement"; // TODO
    }

    public static string TocakiToFrench(string textInput) {
        // Utilise Regex pour remplacer chaque occurrence selon les paires définies dans le dictionnaire
        string temp = string.Join("|", _replacements.Keys.Select(Regex.Escape)); // TODO refactoriser dans l'appel de méthode dessous une fois que c'est compris
        string resultString = Regex.Replace(textInput, temp, m => _replacements[m.Value]); // TODO Q? ça fait quoi cette ligne gpt ?

        return resultString;
        // TODO utiliser chagpt pour passer en bon français
    }

    public static LexicalToken GetTocakiWord(string userInput) // TODO Q? quelle est la bonne façon pour aller chercher un objet ? Une factory mais ?
    {
        lock(_treadSafeLoker) {
            if(_dictionnary == null) {
                InitializeDictionary();
            }
        }

        Type tokenType = typeof(Token_tocaki);
        PropertyInfo phoneticsProperty = tokenType.GetProperty("Phonetics");
        string phonetics = (string)(phoneticsProperty!.GetValue(null) ?? "");

        Console.WriteLine("Texte lu : " + phonetics);

        return new Token_tocaki();
        // TODO
    }

    private static void InitializeDictionary() {
        foreach
    }
}
