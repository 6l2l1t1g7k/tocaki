using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_bo : LexicalToken
{
    public override string Phonetics { get => "bo"; }
    public override string DefinitionInTocaki { get => ">"; }
    public override string DefinitionInFrench { get => "marque du comparatif supérieur, plus"; }
    public override List<string> FrenchWordsAssociated { get => ["plus grand que"]; }

    public override List<Type> ParentConcepts { get => []; }
}
