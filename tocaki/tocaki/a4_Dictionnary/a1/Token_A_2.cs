namespace tocaki.a4_Dictionary.a1;

public class Token_A : LexicalToken // TODO Q? retirer le % du nom de fichier
{
    public override string Phonetics { get => "A"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => string.Empty; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
