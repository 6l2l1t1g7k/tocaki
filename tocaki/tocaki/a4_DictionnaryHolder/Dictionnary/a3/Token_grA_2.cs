using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_grA : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "grA"; }
    public override string DefinitionInTocaki { get => "19"; }
    public override string DefinitionInFrench { get => "dix-neuf, 19"; }
    public override List<string> FrenchWordsAssociated { get => ["19"]; }
}
