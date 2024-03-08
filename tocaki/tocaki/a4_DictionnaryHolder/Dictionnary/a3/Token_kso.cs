using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_kso : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kso"; }
    public override string DefinitionInTocaki { get => "22"; }
    public override string DefinitionInFrench { get => "vingt-deux, 22"; }
    public override List<string> FrenchWordsAssociated { get => ["22"]; }
}
