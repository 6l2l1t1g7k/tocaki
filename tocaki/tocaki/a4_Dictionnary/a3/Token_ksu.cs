using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_ksu : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "ksu"; }
    public override string DefinitionInTocaki { get => "24"; }
    public override string DefinitionInFrench { get => "vingt-quatre, 24"; }
    public override List<string> FrenchWordsAssociated { get => ["24"]; }
}
