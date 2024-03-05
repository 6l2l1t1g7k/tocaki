using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kla : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kla"; }
    public override string DefinitionInTocaki { get => "kla"; }
    public override string DefinitionInFrench { get => "marqueur des assertions"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}