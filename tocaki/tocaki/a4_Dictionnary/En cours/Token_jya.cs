namespace tocaki.a4_Dictionary.a3;

public class Token_jya : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "jya"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; } // TODO remplacer tout les []-rEglu par des []-vuma-*
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
