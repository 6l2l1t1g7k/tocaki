namespace tocaki.a4_Dictionary.a3;

public class Token_mya : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "mya"; }
    public override string DefinitionInTocaki { get => "mya"; }
    public override string DefinitionInFrench { get => "Les choses fausses suffixe marqueur de chose lié au faux."; }
    public override List<string> FrenchWordsAssociated { get => ["faux"]; }
}
