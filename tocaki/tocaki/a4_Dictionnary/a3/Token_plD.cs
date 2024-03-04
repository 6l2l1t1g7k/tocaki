using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_plD : LexicalToken
{
    public override string Phonetics { get => "plD"; }
    public override string DefinitionInTocaki { get => "63"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["63"]; }

    public override List<Type> ParentConcepts { get => []; }
}
