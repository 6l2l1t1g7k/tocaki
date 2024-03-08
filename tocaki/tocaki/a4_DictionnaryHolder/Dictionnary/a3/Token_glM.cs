using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_glM : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "glM"; }
    public override string DefinitionInTocaki { get => "↓ = ¬∨"; }
    public override string DefinitionInFrench { get => "disjonction réciproque, non ou"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
