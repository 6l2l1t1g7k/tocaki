using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_plM : LexicalToken
{
    public override string Phonetics { get => "plM"; }
    public override string DefinitionInTocaki { get => "67"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
