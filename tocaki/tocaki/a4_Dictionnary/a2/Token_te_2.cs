
namespace tocaki.a4_Dictionary.a2;

public class Token_tE_2 : LexicalToken
{
    public override string Phonetics { get => "tE"; }
    public override string DefinitionInTocaki { get => "⊢"; }
    public override string DefinitionInFrench { get => "donc, conclusion"; }
    public override List<string> FrenchWordsAssociated { get => ["donc", "conclusion"]; }

    public override List<Type> ParentConcepts { get => []; }
}
