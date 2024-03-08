using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_we : LexicalToken
{
    public override string Phonetics { get => "we"; }
    public override string DefinitionInTocaki { get => "w"; }
    public override string DefinitionInFrench { get => "w"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
