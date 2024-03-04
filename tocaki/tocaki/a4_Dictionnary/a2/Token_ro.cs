using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_ro : LexicalToken
{
    public override string Phonetics { get => "ro"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
