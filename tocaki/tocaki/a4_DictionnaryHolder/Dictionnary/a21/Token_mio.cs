using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a21;

public class Token_mio : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "mio"; }
    public override string DefinitionInTocaki { get => "possessif pluriel de fi (fu⋃ri)"; }
    public override string DefinitionInFrench { get => "leurs"; }
    public override List<string> FrenchWordsAssociated { get => ["leurs"]; }
}
