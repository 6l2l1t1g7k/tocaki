using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a21;

public class Token_lio : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "lio"; }
    public override string DefinitionInTocaki { get => "Possessif pluriel de jH (⋃(ja,fu,ri))"; }
    public override string DefinitionInFrench { get => "nos"; }
    public override List<string> FrenchWordsAssociated { get => ["nos"]; }
}
