using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a21;

public class Token_luo : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "luo"; }
    public override string DefinitionInTocaki { get => "Possessif pluriel de ju (ja⋃fu)"; }
    public override string DefinitionInFrench { get => "nos"; }
    public override List<string> FrenchWordsAssociated { get => ["nos"]; }
}
