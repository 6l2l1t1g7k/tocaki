using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a23;

public class Token_rumze : LexicalToken {
    public string EnsembleDeDepart { get; set; } = "E";
    public string EnsembleDarrive { get; set; } = "F";
    public string EnsembleDeLaRelation { get; set; } = "G";
    public override List<Type> ParentConcepts => [];
    public override string Phonetics => "rumze";
    public override string DefinitionInTocaki => $"Une rumze R d'une classe {EnsembleDeDepart} vers une classe {EnsembleDarrive} est une partie {EnsembleDeLaRelation} de {EnsembleDeDepart} × {EnsembleDarrive}.";
    public override string DefinitionInFrench => "Une rumze R d'une classe E vers une classe F est une partie G de E × F.";
    public override List<string> FrenchWordsAssociated => ["proto-fonction", "relation binaire"];
}
