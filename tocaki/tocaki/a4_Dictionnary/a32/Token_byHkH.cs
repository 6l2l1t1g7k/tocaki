namespace tocaki.a4_Dictionary.a32;

public class Token_byHkH : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "byHkH"; } // TODO automatiser le d�coupage des phon�mes avec leurs r�servations et usages
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "les choses qui sont autoritaires"; }
    public override List<string> FrenchWordsAssociated { get => ["autoritaire"]; }
}
