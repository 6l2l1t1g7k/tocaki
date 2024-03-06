namespace tocaki.a4_Dictionary.a3;

public class Token_mwe : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "mwe"; }
    public override string DefinitionInTocaki { get => "m"; }
    public override string DefinitionInFrench { get => "La lettre m."; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
