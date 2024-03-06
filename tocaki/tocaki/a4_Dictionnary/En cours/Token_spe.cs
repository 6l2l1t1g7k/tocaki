namespace tocaki.a4_Dictionary.a3;

public class Token_spe : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "spe"; }
    public override string DefinitionInTocaki { get => "80"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["80"]; }
}
