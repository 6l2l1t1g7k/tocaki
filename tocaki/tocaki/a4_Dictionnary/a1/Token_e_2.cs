namespace tocaki.a4_Dictionnary.a1;

public class Token_e : LexicalToken // TODO Q? retirer le % du nom de fichier
{
    public override string Phonetics { get => "e"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => string.Empty; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
