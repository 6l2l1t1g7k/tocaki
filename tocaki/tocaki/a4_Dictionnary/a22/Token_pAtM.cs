namespace tocaki.a4_Dictionary.a22;

public class Token_pAtM : LexicalToken { // TODO Q? comment rendre chaque classe unique sans passer par le nom ? Rendre le champ phonétique, unique dans le projet
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "pAtM"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Les choses qui ont de l’audace."; }
    public override List<string> FrenchWordsAssociated { get => ["audace"]; }
}
