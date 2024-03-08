using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_mi : LexicalToken
{
    public override string Phonetics { get => "mi"; }
    public override string DefinitionInTocaki { get => "possessif singulier de fi (fu⋃ri)"; }
    public override string DefinitionInFrench { get => "votre"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
