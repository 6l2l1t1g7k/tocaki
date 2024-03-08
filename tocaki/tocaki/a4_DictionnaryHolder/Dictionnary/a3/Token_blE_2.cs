using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_blE : LexicalToken
{
    public override string Phonetics { get => "blE"; }
    public override string DefinitionInTocaki { get => "∅5"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["5", "cinq"]; }

    public override List<Type> ParentConcepts { get => []; }
}
