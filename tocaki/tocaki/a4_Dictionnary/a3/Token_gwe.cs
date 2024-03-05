using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_gwe : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gwe"; }
    public override string DefinitionInTocaki { get => "g"; }
    public override string DefinitionInFrench { get => "la lettre g"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
