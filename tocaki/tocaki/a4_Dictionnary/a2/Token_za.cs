using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_za : LexicalToken
{
    public override string Phonetics { get => "za"; }
    public override string DefinitionInTocaki { get => "="; }
    public override string DefinitionInFrench { get => "=, égal, être"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
