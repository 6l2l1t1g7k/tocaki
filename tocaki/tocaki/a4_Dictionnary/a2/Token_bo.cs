namespace tocaki.a4_Dictionnary.a2;

public class Token_bo : LexicalToken
{
    public override string Phonetics { get => "bo"; }
    public override string DefinitionInTocaki { get => ">"; }
    public override string DefinitionInFrench { get => "marque du comparatif supérieur, plus"; }
    public override List<string> FrenchWordsAssociated { get => ["plus grand que"]; }
}
