using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_blD : LexicalToken
{
    public override string Phonetics { get => "blD"; }
    public override string DefinitionInTocaki { get => "∅3"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["3", "trois"]; }

    public override List<Type> ParentConcepts { get => []; }
}
