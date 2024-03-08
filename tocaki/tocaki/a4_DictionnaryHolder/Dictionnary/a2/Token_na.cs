using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_na : LexicalToken
{
    public override string Phonetics { get => "na"; }
    public override string DefinitionInTocaki { get => "na"; }
    public override string DefinitionInFrench { get => "parent (radical parental)"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
