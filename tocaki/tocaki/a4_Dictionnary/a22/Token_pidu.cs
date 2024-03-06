namespace tocaki.a4_Dictionary.a22;

public class Token_pidu : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "pidu"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Choses dont l’évaluation est imprécise"; }
    public override List<string> FrenchWordsAssociated { get => ["approximatif", "imprécis"]; }
}
