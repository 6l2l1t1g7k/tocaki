using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_fu : LexicalToken
{
    public override string Phonetics { get => "fu"; }
    public override string DefinitionInTocaki { get => "fu"; }
    public override string DefinitionInFrench { get => "« tu »"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
