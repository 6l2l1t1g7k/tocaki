using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_bRu : LexicalToken
{
    public override string Phonetics { get => "bRu"; }
    public override string DefinitionInTocaki { get => "∅∅∅"; }
    public override string DefinitionInFrench { get => "Collison phonétique avec \"bru\"."; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
