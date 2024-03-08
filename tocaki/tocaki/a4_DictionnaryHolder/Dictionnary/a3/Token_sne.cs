using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_sne : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "sne"; }
    public override string DefinitionInTocaki { get => "10^3"; }
    public override string DefinitionInFrench { get => "10^3"; }
    public override List<string> FrenchWordsAssociated { get => ["1000, mille"]; }
}
