using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_pri : LexicalToken
{
    public override string Phonetics { get => "pri"; }
    public override string DefinitionInTocaki { get => "pri"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["violent"]; }

    public override List<Type> ParentConcepts { get => []; }
}
