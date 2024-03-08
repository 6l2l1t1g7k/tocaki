using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_ga : LexicalToken
{
    public override string Phonetics { get => "ga"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "marque des adverbes « -ement » « de façon … »"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
