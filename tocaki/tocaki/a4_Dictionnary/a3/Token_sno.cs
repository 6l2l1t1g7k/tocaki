namespace tocaki.a4_Dictionary.a3;

public class Token_sno : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "sno"; }
    public override string DefinitionInTocaki { get => "10^9"; }
    public override string DefinitionInFrench { get => "10^9"; }
    public override List<string> FrenchWordsAssociated { get => ["milliard"]; }
}
