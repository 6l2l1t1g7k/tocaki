using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_ksA : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "ksA"; }
    public override string DefinitionInTocaki { get => "29"; }
    public override string DefinitionInFrench { get => "vingt-neuf, 29"; }
    public override List<string> FrenchWordsAssociated { get => ["29"]; }
}
