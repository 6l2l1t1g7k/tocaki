namespace tocaki.a4_Dictionnary.a1;

public class Token_N : LexicalToken
{
    public override string Phonetics { get => "N"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => string.Empty; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
