
namespace tocaki.a4_Dictionary.a2;

public class Token_ke : LexicalToken
{
    public override string Phonetics { get => "ke"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => "utiliser pour des animaux, le vivant animé"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
