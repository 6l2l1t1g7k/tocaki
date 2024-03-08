using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_zbi : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "zbi"; }
    public override string DefinitionInTocaki { get => "⇒"; }
    public override string DefinitionInFrench { get => "implication"; }
    public override List<string> FrenchWordsAssociated { get => ["implique"]; }
}
