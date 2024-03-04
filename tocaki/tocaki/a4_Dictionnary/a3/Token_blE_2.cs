using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_blE : LexicalToken
{
    public override string Phonetics { get => "blE"; }
    public override string DefinitionInTocaki { get => "∅5"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["5", "cinq"]; }

    public override List<Type> ParentConcepts { get => []; }
}
