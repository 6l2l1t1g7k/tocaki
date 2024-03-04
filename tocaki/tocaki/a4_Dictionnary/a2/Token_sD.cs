using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_sD : LexicalToken
{
    public override string Phonetics { get => "sD"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
