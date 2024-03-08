using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_gri : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gri"; }
    public override string DefinitionInTocaki { get => "1∅"; }
    public override string DefinitionInFrench { get => "un, 1"; }
    public override List<string> FrenchWordsAssociated { get => ["1"]; }
}
