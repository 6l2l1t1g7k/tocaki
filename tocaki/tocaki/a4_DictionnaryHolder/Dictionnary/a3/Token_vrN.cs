using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_vrN : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public List<Type> LinkedConcepts { get => [typeof(Token_vcA)]; }
    public override string Phonetics { get => "vrN"; }
    public override string DefinitionInTocaki { get => "⋊"; }
    public override string DefinitionInFrench { get => "(a vrN b=a) = (a ne dépend pas de b)"; }
    public override List<string> FrenchWordsAssociated { get => ["indépendant"]; }
}
