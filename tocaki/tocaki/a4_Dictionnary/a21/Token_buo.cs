using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a21;

public class Token_buo : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "buo"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "tes"; }
    public override List<string> FrenchWordsAssociated { get => ["tes"]; }
}
