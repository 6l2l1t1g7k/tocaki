using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_fi : LexicalToken
{
    public override string Phonetics { get => "fi"; }
    public override string DefinitionInTocaki { get => "fu⋃ri"; }
    public override string DefinitionInFrench { get => "« tu » et « il », vous"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
