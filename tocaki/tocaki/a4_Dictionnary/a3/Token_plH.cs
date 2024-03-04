using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_plH : LexicalToken
{
    public override string Phonetics { get => "plH"; }
    public override string DefinitionInTocaki { get => "68"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["68"]; }

    public override List<Type> ParentConcepts { get => []; }
}
