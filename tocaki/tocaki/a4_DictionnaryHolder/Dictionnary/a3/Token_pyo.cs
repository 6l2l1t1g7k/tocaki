using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_pyo : LexicalToken
{
    public override string Phonetics { get => "pyo"; }
    public override string DefinitionInTocaki { get => "pyo"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["important"]; }

    public override List<Type> ParentConcepts { get => []; }
}
