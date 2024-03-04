
namespace tocaki.a4_Dictionary.a2;

public class Token_di : LexicalToken
{
    public override string Phonetics { get => "di"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "les"; }
    public override List<string> FrenchWordsAssociated { get => ["les"]; }

    public override List<Type> ParentConcepts { get => []; }
}
