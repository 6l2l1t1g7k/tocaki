using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_rH : LexicalToken
{
    public override string Phonetics { get => "rH"; }
    public override string DefinitionInTocaki { get => "jE⋃fu⋃li"; }
    public override string DefinitionInFrench { get => "« je », « tu » et « il », une sorte de « nous »"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
