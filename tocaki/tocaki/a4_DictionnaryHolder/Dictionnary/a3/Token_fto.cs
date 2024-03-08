using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_fto : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "fto"; }
    public override string DefinitionInTocaki { get => "42"; }
    public override string DefinitionInFrench { get => "42"; }
    public override List<string> FrenchWordsAssociated { get => ["42"]; }
}
