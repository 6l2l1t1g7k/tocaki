using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_byH : LexicalToken
{
    public override string Phonetics { get => "byH"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
