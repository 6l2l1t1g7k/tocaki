using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_dre : LexicalToken
{
    public override string Phonetics { get => "dre"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "marqueur de l’intensité 7/10"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
