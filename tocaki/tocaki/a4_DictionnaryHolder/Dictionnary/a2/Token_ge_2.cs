using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_ge : LexicalToken
{
    public override string Phonetics { get => "ge"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "Intensité 10/10"; }
    public override List<string> FrenchWordsAssociated { get => ["parfait"]; }

    public override List<Type> ParentConcepts { get => []; }
}
