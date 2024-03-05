using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kwD : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kwD"; }
    public override string DefinitionInTocaki { get => "10^8"; }
    public override string DefinitionInFrench { get => "10^8"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
