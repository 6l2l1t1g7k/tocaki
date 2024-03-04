using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_ple : LexicalToken
{
    public override string Phonetics { get => "ple"; }
    public override string DefinitionInTocaki { get => "60"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["60"]; }

    public override List<Type> ParentConcepts { get => []; }
}
