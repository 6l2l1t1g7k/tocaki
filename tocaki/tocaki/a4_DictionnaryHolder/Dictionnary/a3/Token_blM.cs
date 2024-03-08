using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_blM : LexicalToken
{
    public override string Phonetics { get => "blM"; }
    public override string DefinitionInTocaki { get => "∅7"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["7", "sept"]; }

    public override List<Type> ParentConcepts { get => []; }
}
