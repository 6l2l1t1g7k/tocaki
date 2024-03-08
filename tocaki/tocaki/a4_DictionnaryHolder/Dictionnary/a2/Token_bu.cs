using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_bu : LexicalToken
{
    public override string Phonetics { get => "bu"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "ton, ta"; }
    public override List<string> FrenchWordsAssociated { get => ["ton", "ta"]; }

    public override List<Type> ParentConcepts { get => []; }
}
