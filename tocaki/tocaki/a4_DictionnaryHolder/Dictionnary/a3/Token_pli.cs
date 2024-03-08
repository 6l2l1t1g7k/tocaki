using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_pli : LexicalToken
{
    public override string Phonetics { get => "pli"; }
    public override string DefinitionInTocaki { get => "6∅"; }
    public override string DefinitionInFrench { get => "six, 6"; }
    public override List<string> FrenchWordsAssociated { get => ["6", "six"]; }

    public override List<Type> ParentConcepts { get => []; }
}
