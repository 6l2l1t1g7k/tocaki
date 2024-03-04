
namespace tocaki.a4_Dictionary.a2;

public class Token_be : LexicalToken
{
    public override string Phonetics { get => "be"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => string.Empty; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
