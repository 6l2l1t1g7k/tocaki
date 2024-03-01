using System.Text;

namespace tocaki.a4_Dictionary;

public abstract class LexicalToken // TODO Q? putôt interface ou classe abstraire ?
{
    // TODO chaque mot doit avoir un et un seul parent principal => arbre d"héritage, qu'est ce que ça apporte d'avoir une représentation par un arbre principal plutôt que de se contenter du graphe des connaissances ?
    // pour les autre liens d'endance possible il suffit de créer des lients avec un liste et là ça va faire un graphe en bordel mais c'est pas grave
    // mettre en place en susyème qui gère cette gestion de graphe du langage

    public abstract string Phonetics { get; }
    public virtual string DefinitionInTocaki { get; } = string.Empty;
    public abstract string DefinitionInFrench { get; }

    /// <summary>
    /// Le premier mot est la traduction principale, si un dossier d'analyse aprondi existe ce serra sous ce nom dans le "dossier des connaissances"
    /// </summary>
    public virtual List<string> FrenchWordsAssociated { get; } = []; // TODO implémenter la recherche qui permet de trouver tout les mots tocaki qui font mention du mot français
    public virtual List<Type> AssociatedConcepts { get; } = [];

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
