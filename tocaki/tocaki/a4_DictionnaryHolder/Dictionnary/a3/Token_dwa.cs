using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_dwa : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "dwa"; }
    public override string DefinitionInTocaki { get => "dwa"; }
    public override string DefinitionInFrench { get => "Les états psychique de contentement et de satisfaction sereine"; }
    public override List<string> FrenchWordsAssociated { get => ["béat", "béatitude"]; }
}
