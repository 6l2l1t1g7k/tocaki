using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_glA : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "glA"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "marqueur de l’intensité 9/10"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
