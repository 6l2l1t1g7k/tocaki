using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_tra : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "tra"; }
    public override string DefinitionInTocaki { get => "31"; }
    public override string DefinitionInFrench { get => "31"; }
    public override List<string> FrenchWordsAssociated { get => ["31"]; }
}
