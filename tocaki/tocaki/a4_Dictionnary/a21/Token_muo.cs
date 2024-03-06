using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a21;

public class Token_muo : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "muo"; }
    public override string DefinitionInTocaki { get => "possessif pluriel de qu (fu1⋃fu2)"; }
    public override string DefinitionInFrench { get => "nos"; }
    public override List<string> FrenchWordsAssociated { get => ["nos"]; }
}
