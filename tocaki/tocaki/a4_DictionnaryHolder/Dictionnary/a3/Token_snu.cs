using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_snu : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "snu"; }
    public override string DefinitionInTocaki { get => "10^12"; }
    public override string DefinitionInFrench { get => "10^12"; }
    public override List<string> FrenchWordsAssociated { get => ["billion"]; }
}
