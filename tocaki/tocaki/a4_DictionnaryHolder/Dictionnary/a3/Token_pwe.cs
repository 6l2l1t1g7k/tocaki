using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_pwe : LexicalToken
{
    public override string Phonetics { get => "pwe"; }
    public override string DefinitionInTocaki { get => "p"; }
    public override string DefinitionInFrench { get => "p"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
