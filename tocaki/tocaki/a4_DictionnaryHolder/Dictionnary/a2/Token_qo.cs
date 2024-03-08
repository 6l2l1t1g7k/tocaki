using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_qo : LexicalToken
{
    public override string Phonetics { get => "qo"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => "marqueur d’intensité ?"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
