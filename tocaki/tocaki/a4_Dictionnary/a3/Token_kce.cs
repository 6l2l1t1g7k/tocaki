using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kce : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kce"; }
    public override string DefinitionInTocaki { get => "c"; }
    public override string DefinitionInFrench { get => "la lettre c"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
