namespace tocaki.a4_Dictionary.a3;

public class Token_sni : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "sni"; }
    public override string DefinitionInTocaki { get => "10^15"; }
    public override string DefinitionInFrench { get => "10^15"; }
    public override List<string> FrenchWordsAssociated { get => ["billiard"]; }
}
