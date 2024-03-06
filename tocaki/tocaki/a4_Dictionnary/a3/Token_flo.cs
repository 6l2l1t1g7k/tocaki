namespace tocaki.a4_Dictionary.a3;

public class Token_flo : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "flo"; }
    public override string DefinitionInTocaki { get => "ɞ"; }
    public override string DefinitionInFrench { get => "Balise qui désigne des affectations pour les propositions suivantes"; }
    public override List<string> FrenchWordsAssociated { get => ["définition", "définir"]; }
}
