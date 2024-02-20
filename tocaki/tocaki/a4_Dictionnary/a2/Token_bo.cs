namespace tocaki.a4_Dictionnary.a1;

public class Token_bA : LexicalToken
{
    public override string Phonetics { get => "bo"; }
    public override string DefinitionInTocaki { get => ">"; }
    public override string DefinitionInFrench { get => "marque du comparatif supérieur, plus"; }
    public override List<string> FrenchWordsAssociated { get => ["plus grand que"]; }
}
