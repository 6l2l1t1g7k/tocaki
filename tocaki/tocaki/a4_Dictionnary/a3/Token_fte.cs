namespace tocaki.a4_Dictionary.a3;

public class Token_fte : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "fte"; }
    public override string DefinitionInTocaki { get => "40"; }
    public override string DefinitionInFrench { get => "40"; }
    public override List<string> FrenchWordsAssociated { get => ["40"]; }
}
