using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a1;

public class Token_µ : LexicalToken
{
    public override string Phonetics { get => "µ"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => string.Empty; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
