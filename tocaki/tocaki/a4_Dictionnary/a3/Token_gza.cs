using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_gza : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gza"; }
    public override string DefinitionInTocaki { get => "∨"; }
    public override string DefinitionInFrench { get => "ou inclusif"; }
    public override List<string> FrenchWordsAssociated { get => ["ou"]; }
}
