
namespace tocaki.a4_Dictionary.a1;

public class Token_i : LexicalToken
{
    public override string Phonetics { get => "i"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => string.Empty; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}