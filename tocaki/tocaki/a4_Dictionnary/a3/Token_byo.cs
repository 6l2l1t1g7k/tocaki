using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_byo : LexicalToken
{
    public override string Phonetics { get => "byo"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "Intensité 4/10"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
