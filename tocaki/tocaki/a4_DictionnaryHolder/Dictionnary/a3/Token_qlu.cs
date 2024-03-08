using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_qlu : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "qlu"; }
    public override string DefinitionInTocaki { get => "∅4"; }
    public override string DefinitionInFrench { get => "quatre, 4"; }
    public override List<string> FrenchWordsAssociated { get => ["4"]; }
}
