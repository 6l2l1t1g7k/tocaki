namespace tocaki.a4_Dictionary.a3;

public class Token_fle : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "fle"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Aller quelque part."; }
    public override List<string> FrenchWordsAssociated { get => ["aller"]; }
}
