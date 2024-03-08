using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_pra : LexicalToken
{
    public override string Phonetics { get => "pra"; }
    public override string DefinitionInTocaki { get => "pra"; }
    public override string DefinitionInFrench { get => "les choses latérales"; }
    public override List<string> FrenchWordsAssociated { get => ["latéral"]; }

    public override List<Type> ParentConcepts { get => []; }
}
