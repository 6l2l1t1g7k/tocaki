using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_qya : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "qya"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "les choses qui font plaisir"; }
    public override List<string> FrenchWordsAssociated { get => ["bon"]; }
}
