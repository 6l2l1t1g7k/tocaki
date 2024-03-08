using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_lwe : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "lwe"; }
    public override string DefinitionInTocaki { get => "l"; }
    public override string DefinitionInFrench { get => "La lettre l."; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
