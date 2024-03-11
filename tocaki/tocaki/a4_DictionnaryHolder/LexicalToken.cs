using System.Text;

namespace tocaki.a4_DictionaryHolder;

/// <summary>
/// Propriété facultative : LinkedConcepts ;
/// </summary>
public abstract class LexicalToken
{
    /// <summary>
    /// Le premier concept est le concept principal, le réseau de concept principal doit constituer et respecter une structure d'arbre
    /// </summary>
    public abstract List<Type> ParentConcepts { get; }
    public abstract string Phonetics { get; }
    public virtual string DefinitionInTocaki { get; } = string.Empty;
    public abstract string DefinitionInFrench { get; }

    /// <summary>
    /// Le premier mot est la traduction principale, si un dossier d'analyse aprondi existe ce serra sous ce nom dans le "dossier des connaissances"
    /// </summary>
    public virtual List<string> FrenchWordsAssociated { get; } = []; // TODO implémenter la recherche qui permet de trouver tout les mots tocaki qui font mention du mot français
    public virtual List<Type> AssociatedConcepts { get; } = [];

    public string PropertiesToString() {
        StringBuilder result = new();

        result.Append($"\nPhonétique : {Phonetics}");
        result.Append($"\nDéfinition tocaki : {DefinitionInTocaki}");
        result.Append($"\nDéfinition en français : {DefinitionInFrench}");

        StringBuilder frenchWordList = new();
        foreach (string word in FrenchWordsAssociated) {
            frenchWordList.Append(" ; ");
            frenchWordList.Append("" + word);
        }
        if (frenchWordList.Length > 3) {
            frenchWordList.Remove(0, 3);
        }

        result.Append($"\nMots français associé : {frenchWordList}");

        return result.ToString();
    }
}
