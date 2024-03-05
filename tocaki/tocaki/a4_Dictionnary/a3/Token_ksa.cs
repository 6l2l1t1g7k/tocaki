using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_ksa : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "ksa"; }
    public override string DefinitionInTocaki { get => "21"; }
    public override string DefinitionInFrench { get => "vingt et un, 21"; }
    public override List<string> FrenchWordsAssociated { get => ["21"]; }
}
