using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_grH : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "grH"; }
    public override string DefinitionInTocaki { get => "18"; }
    public override string DefinitionInFrench { get => "dix-huit, 18"; }
    public override List<string> FrenchWordsAssociated { get => ["18"]; }
}
