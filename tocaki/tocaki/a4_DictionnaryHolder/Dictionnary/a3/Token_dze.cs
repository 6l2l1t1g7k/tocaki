using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_dze : LexicalToken
{
    public override List<Type> ParentConcepts => [];
    public override string Phonetics { get => "dze"; }
    public override string DefinitionInTocaki { get => "90"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["90"]; }
}
