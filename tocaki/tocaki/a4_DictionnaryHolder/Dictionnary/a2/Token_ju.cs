using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_ju : LexicalToken
{
    public override string Phonetics { get => "ju"; }
    public override string DefinitionInTocaki { get => "jE⋃fu"; }
    public override string DefinitionInFrench { get => "« je » et « tu » un équivalent de « nous », « on »"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
