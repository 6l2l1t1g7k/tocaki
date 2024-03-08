using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_wa : LexicalToken
{
    public override string Phonetics { get => "wa"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*\""; }
    public override string DefinitionInFrench { get => "marque du sexe féminin"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
