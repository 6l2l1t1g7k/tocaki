using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_grE : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "grE"; }
    public override string DefinitionInTocaki { get => "15"; }
    public override string DefinitionInFrench { get => "quinze, 15"; }
    public override List<string> FrenchWordsAssociated { get => ["15"]; }
}
