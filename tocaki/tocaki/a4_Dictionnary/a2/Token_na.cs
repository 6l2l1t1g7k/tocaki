using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_na : LexicalToken
{
    public override string Phonetics { get => "na"; }
    public override string DefinitionInTocaki { get => "na"; }
    public override string DefinitionInFrench { get => "parent (radical parental)"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
