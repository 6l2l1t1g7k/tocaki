using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_klo : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "klo"; }
    public override string DefinitionInTocaki { get => "klo"; }
    public override string DefinitionInFrench { get => "marqueur des ordres"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}