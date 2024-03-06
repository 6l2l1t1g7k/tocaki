namespace tocaki.a4_Dictionary.a22;

public class Token_moro : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "moro"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "La forme d’énergie qui transmet de la température."; }
    public override List<string> FrenchWordsAssociated { get => ["chaleur"]; }
}
