using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_fro : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "fro"; }
    public override string DefinitionInTocaki { get => "fro"; }
    public override string DefinitionInFrench { get => "Les choses qui ont une extrême tension nerveuse causée par l'appréhension de certains faits"; }
    public override List<string> FrenchWordsAssociated { get => ["anxieux"]; }
}
