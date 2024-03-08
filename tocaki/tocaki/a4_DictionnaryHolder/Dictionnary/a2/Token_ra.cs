using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_ra : LexicalToken
{
    public override string Phonetics { get => "ra"; }
    public override string DefinitionInTocaki { get => "maRkLR du futuR"; }
    public override string DefinitionInFrench { get => "marqueur du futur"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
