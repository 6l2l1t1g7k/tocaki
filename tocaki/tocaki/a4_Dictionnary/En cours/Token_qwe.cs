namespace tocaki.a4_Dictionary.a3;

public class Token_qwe : LexicalToken {
    public override List<Type> ParentConcepts { get => []; } // TODO retrouver l'alphabet tocaki manuscrit
    public override string Phonetics { get => "qwe"; }
    public override string DefinitionInTocaki { get => "q"; }
    public override string DefinitionInFrench { get => "La lettre q."; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
