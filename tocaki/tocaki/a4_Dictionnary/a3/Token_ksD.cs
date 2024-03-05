using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_ksD : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "ksD"; }
    public override string DefinitionInTocaki { get => "23"; }
    public override string DefinitionInFrench { get => "vingt-trois, 23"; }
    public override List<string> FrenchWordsAssociated { get => ["23"]; }
}
