using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a21;

public class Token_luo : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "luo"; }
    public override string DefinitionInTocaki { get => "Possessif pluriel de ju (ja⋃fu)"; }
    public override string DefinitionInFrench { get => "nos"; }
    public override List<string> FrenchWordsAssociated { get => ["nos"]; }
}
