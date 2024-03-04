using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_bla : LexicalToken
{
    public override string Phonetics { get => "bla"; }
    public override string DefinitionInTocaki { get => "∅1"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["1", "un"]; }

    public override List<Type> ParentConcepts { get => []; }
}
