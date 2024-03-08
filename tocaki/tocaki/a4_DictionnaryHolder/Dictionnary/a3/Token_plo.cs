using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_plo : LexicalToken
{
    public override string Phonetics { get => "plo"; }
    public override string DefinitionInTocaki { get => "62"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["62"]; }

    public override List<Type> ParentConcepts { get => []; }
}
