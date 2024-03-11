using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_zwi : LexicalToken
{
    public override string Phonetics { get => "zwi"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => [""]; }

    public override List<Type> ParentConcepts { get => []; }
}
