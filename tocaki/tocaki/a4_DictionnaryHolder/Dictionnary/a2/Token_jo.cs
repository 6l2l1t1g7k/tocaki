using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_jo : LexicalToken
{
    public override string Phonetics { get => "jo"; }
    public override string DefinitionInTocaki { get => "⊆"; }
    public override string DefinitionInFrench { get => "⊆, est inclus, être; exemple : les femmes sont des humaines/lefyawajolefya"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
