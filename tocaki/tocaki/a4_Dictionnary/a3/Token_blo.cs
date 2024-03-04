using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_blo : LexicalToken
{
    public override string Phonetics { get => "blo"; }
    public override string DefinitionInTocaki { get => "∅2"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["2", "deux"]; }

    public override List<Type> ParentConcepts { get => []; }
}
