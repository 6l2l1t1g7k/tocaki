using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_ve : LexicalToken
{
    public override string Phonetics { get => "ve"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => "marque des adjectifs ?(pas sur d’en avoir besoin)"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
