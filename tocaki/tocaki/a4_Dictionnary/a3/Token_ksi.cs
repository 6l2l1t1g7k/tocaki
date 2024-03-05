using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_ksi : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "ksi"; }
    public override string DefinitionInTocaki { get => "2∅"; }
    public override string DefinitionInFrench { get => "deux, 2"; }
    public override List<string> FrenchWordsAssociated { get => ["2"]; }
}
