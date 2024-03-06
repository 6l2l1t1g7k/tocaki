namespace tocaki.a4_Dictionary.a3;

public class Token_refa : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "refa"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Relatif à la chair."; }
    public override List<string> FrenchWordsAssociated { get => ["charnel"]; }
}
