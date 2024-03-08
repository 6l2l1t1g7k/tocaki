using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_qwi : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "qwi"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "marque de chose générique"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
