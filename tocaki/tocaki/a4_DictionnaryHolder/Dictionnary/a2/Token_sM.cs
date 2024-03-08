using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_sM : LexicalToken
{
    public override string Phonetics { get => "sM"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => "radical pour des objets"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
