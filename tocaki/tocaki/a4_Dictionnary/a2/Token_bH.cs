
namespace tocaki.a4_Dictionary.a2;

public class Token_bH : LexicalToken
{
    public override string Phonetics { get => "bH"; }
    public override string DefinitionInTocaki { get => ")"; }
    public override string DefinitionInFrench { get => "Parenthèse fermante, pour la priorité syntaxique."; }
    public override List<string> FrenchWordsAssociated { get => [""]; }

    public override List<Type> ParentConcepts { get => []; }
}
