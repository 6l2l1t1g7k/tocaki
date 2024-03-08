using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_blu : LexicalToken
{
    public override string Phonetics { get => "blu"; }
    public override string DefinitionInTocaki { get => "∅4"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["4", "quatre"]; }

    public override List<Type> ParentConcepts { get => []; }
}
