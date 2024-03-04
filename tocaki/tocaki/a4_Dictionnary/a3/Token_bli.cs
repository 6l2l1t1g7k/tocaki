using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_bli : LexicalToken
{
    public override string Phonetics { get => "bli"; }
    public override string DefinitionInTocaki { get => "∅∅"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["rien"]; }

    public override List<Type> ParentConcepts { get => []; }
}
