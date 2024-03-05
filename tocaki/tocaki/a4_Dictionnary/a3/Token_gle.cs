using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_gle : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gle"; }
    public override string DefinitionInTocaki { get => "gle"; }
    public override string DefinitionInFrench { get => "les choses du bas"; }
    public override List<string> FrenchWordsAssociated { get => ["bas"]; }
}
