using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a21;

public class Token_nio : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "nio"; }
    public override string DefinitionInTocaki { get => "possessif pluriel de qi (ri1⋃ri2)"; }
    public override string DefinitionInFrench { get => "leurs"; }
    public override List<string> FrenchWordsAssociated { get => ["leurs"]; }
}
