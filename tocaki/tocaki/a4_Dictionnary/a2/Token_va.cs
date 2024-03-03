using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_va : LexicalToken
{
    public override string Phonetics { get => "va"; }
    public override string DefinitionInTocaki { get => "("; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
