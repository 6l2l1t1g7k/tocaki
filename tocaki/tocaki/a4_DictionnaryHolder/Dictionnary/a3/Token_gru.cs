using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_gru : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gru"; }
    public override string DefinitionInTocaki { get => "14"; }
    public override string DefinitionInFrench { get => "quatorze, 14"; }
    public override List<string> FrenchWordsAssociated { get => ["14"]; }
}
