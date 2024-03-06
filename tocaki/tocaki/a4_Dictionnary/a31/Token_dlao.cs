using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a31;

public class Token_dlao : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "dlao"; }
    public override string DefinitionInTocaki { get => "Possessif pluriel de qE (ja1⋃ja2)"; }
    public override string DefinitionInFrench { get => "nos"; }
    public override List<string> FrenchWordsAssociated { get => ["nos"]; }
}
