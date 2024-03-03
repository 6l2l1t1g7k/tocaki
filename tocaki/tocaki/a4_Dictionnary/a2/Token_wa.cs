using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_wa : LexicalToken
{
    public override string Phonetics { get => "wa"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*\""; }
    public override string DefinitionInFrench { get => "marque du sexe féminin"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
