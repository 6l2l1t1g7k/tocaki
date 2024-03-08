using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_spi : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "spi"; }
    public override string DefinitionInTocaki { get => "8∅"; }
    public override string DefinitionInFrench { get => "huit, 8"; }
    public override List<string> FrenchWordsAssociated { get => ["8"]; }
}
