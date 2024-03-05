using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_grM : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "grM"; }
    public override string DefinitionInTocaki { get => "17"; }
    public override string DefinitionInFrench { get => "dix-sept, 17"; }
    public override List<string> FrenchWordsAssociated { get => ["17"]; }
}
