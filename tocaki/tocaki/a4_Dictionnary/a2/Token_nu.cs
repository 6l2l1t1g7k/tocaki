using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_nu : LexicalToken
{
    public override string Phonetics { get => "nu"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => "marqueur des temps descriptif"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
