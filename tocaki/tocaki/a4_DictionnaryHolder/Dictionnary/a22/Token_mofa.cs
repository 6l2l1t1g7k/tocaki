using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a22; // TODO Q? est ce qu'il vaut mieux tout mettre dans un seul namespace ? à quel point c'est plus lourd à la compilation ?

public class Token_mofa : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "mofa"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
