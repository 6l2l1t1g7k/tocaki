using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_grD : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "grD"; }
    public override string DefinitionInTocaki { get => "13"; }
    public override string DefinitionInFrench { get => "treize, 13"; }
    public override List<string> FrenchWordsAssociated { get => ["13"]; }
}
