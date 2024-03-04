
namespace tocaki.a4_Dictionary.a2;

public class Token_jo : LexicalToken
{
    public override string Phonetics { get => "jo"; }
    public override string DefinitionInTocaki { get => "⊆"; }
    public override string DefinitionInFrench { get => "⊆, est inclus, être; exemple : les femmes sont des humaines/lefyawajolefya"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
