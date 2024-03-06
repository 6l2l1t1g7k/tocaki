namespace tocaki.a4_Dictionary.a22;

public class Token_tezo : LexicalToken { // TODO distNge protofMksyM, fMksyM e aplikasyM
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "tezo"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "état psychologique qui vise un but"; }
    public override List<string> FrenchWordsAssociated { get => ["envie", "désir"]; }
}
