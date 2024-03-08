using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_fu : LexicalToken
{
    public override string Phonetics { get => "fu"; }
    public override string DefinitionInTocaki { get => "fu"; }
    public override string DefinitionInFrench { get => "« tu »"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
