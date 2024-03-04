
namespace tocaki.a4_Dictionary.a2;

public class Token_ta : LexicalToken
{
    public override string Phonetics { get => "ta"; }
    public override string DefinitionInTocaki { get => "∀"; }
    public override string DefinitionInFrench { get => "∀, quantificateur universel"; }
    public override List<string> FrenchWordsAssociated { get => ["tout"]; }

    public override List<Type> ParentConcepts { get => []; }
}
