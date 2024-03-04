using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_pla : LexicalToken
{
    public override string Phonetics { get => "pla"; }
    public override string DefinitionInTocaki { get => "61"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["61"]; }

    public override List<Type> ParentConcepts { get => []; }
}
