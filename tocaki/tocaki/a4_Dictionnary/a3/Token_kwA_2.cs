using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kwA : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kwA"; }
    public override string DefinitionInTocaki { get => "10^16"; }
    public override string DefinitionInFrench { get => "10^16"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
