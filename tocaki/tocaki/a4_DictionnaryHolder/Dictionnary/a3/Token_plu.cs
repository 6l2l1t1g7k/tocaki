using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_plu : LexicalToken
{
    public override string Phonetics { get => "plu"; }
    public override string DefinitionInTocaki { get => "64"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["64"]; }

    public override List<Type> ParentConcepts { get => []; }
}
