namespace tocaki.a4_Dictionary.a3;

public class Token_vda : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "vda"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Avoir l'intention, le souhait, le désir de."; }
    public override List<string> FrenchWordsAssociated { get => ["vouloir"]; }
}
