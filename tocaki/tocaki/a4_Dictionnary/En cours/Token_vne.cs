namespace tocaki.a4_Dictionary.a3;

public class Token_vne : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "vne"; }
    public override string DefinitionInTocaki { get => "70"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["70"]; }
}
