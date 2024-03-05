using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_ksH : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "ksH"; }
    public override string DefinitionInTocaki { get => "28"; }
    public override string DefinitionInFrench { get => "vingt-huit, 28"; }
    public override List<string> FrenchWordsAssociated { get => ["28"]; }
}
