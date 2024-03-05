using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kle : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kle"; }
    public override string DefinitionInTocaki { get => "∧"; }
    public override string DefinitionInFrench { get => "et"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}