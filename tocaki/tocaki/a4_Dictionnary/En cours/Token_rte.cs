namespace tocaki.a4_Dictionary.a3;

public class Token_rte : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "rte"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
