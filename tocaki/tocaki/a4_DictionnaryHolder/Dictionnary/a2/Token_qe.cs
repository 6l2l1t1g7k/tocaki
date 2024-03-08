using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_qe : LexicalToken
{
    public override string Phonetics { get => "qe"; }
    public override string DefinitionInTocaki { get => "qe"; }
    public override string DefinitionInFrench { get => "marque du pluriel"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
