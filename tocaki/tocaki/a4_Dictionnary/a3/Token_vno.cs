using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_vno : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "vno"; }
    public override string DefinitionInTocaki { get => "72"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["72"]; }
}
