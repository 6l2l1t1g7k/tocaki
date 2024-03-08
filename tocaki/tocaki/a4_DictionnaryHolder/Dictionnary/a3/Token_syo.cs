using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_syo : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "syo"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => "les choses vrai marqueur de concept lié à la vérité"; }
    public override List<string> FrenchWordsAssociated { get => ["vrai"]; }
}
