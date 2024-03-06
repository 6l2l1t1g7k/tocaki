using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_swe : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "swe"; }
    public override string DefinitionInTocaki { get => "s"; }
    public override string DefinitionInFrench { get => "La lettre s."; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
