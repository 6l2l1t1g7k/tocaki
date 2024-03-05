using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kwu : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kwu"; }
    public override string DefinitionInTocaki { get => "10^28"; }
    public override string DefinitionInFrench { get => "10^28"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
