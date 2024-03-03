using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_su : LexicalToken
{
    public override string Phonetics { get => "su"; }
    public override string DefinitionInTocaki { get => "+"; }
    public override string DefinitionInFrench { get => "+,addition,plus"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
