using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace tocaki.a4_Dictionnary;

public abstract class LexicalToken // TODO Q? putôt interface ou classe abstraire ?
{
    public abstract string Phonetics { get; }
    public abstract string DefinitionInTocaki { get; }
    public abstract string DefinitionInFrench { get; }
    public abstract List<string> FrenchWordsAssociated { get; } // TODO implémenter la recherche qui permet de trouver tout les mots tocaki qui font mention du mot français

    public string PropertiesToString()
    {
        StringBuilder result = new();

        result.Append($"Phonétique : {Phonetics}");
        result.Append($"\nDéfinition tocaki : {DefinitionInTocaki}");
        result.Append($"\nDéfinition en français : {DefinitionInFrench}");

        StringBuilder frenchWordList = new();
        foreach (string word in FrenchWordsAssociated)
        {
            result.Append(" ; ");
            result.Append("" + word);
        }
        if (frenchWordList.Length > 3)
        {
            frenchWordList.Remove(0, 3);
        }

        result.Append($"\nMots français associé : {frenchWordList}");

        return result.ToString();
    }
}
