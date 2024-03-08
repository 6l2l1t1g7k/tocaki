using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_swe : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "swe"; }
    public override string DefinitionInTocaki { get => "s"; }
    public override string DefinitionInFrench { get => "La lettre s."; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
