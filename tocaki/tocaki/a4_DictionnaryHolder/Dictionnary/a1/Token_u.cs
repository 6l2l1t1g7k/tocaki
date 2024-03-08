using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a1;

public class Token_u : LexicalToken
{
    public override string Phonetics { get => "u"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => string.Empty; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}