
namespace tocaki.a4_Dictionary.a2;

public class Token_ji : LexicalToken
{
    public override string Phonetics { get => "ji"; }
    public override string DefinitionInTocaki { get => "jE⋃ri"; }
    public override string DefinitionInFrench { get => "« je » et « il » un équivalent de « nous », « on »"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
