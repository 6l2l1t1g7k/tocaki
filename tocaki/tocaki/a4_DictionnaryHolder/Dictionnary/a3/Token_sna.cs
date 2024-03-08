using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_sna : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "sna"; }
    public override string DefinitionInTocaki { get => "10^6"; }
    public override string DefinitionInFrench { get => "10^6"; }
    public override List<string> FrenchWordsAssociated { get => ["million"]; }
}
