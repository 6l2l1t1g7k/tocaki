using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_gro : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gro"; }
    public override string DefinitionInTocaki { get => "12"; }
    public override string DefinitionInFrench { get => "douze, 12"; }
    public override List<string> FrenchWordsAssociated { get => ["12"]; }
}
