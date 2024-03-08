using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_qi : LexicalToken
{
    public override string Phonetics { get => "qi"; }
    public override string DefinitionInTocaki { get => "reglu-[] /!\\ qi ya : qya etc."; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
