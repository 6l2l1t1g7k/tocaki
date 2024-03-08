using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_ri : LexicalToken
{
    public override string Phonetics { get => "ri"; }
    public override string DefinitionInTocaki { get => "ri"; }
    public override string DefinitionInFrench { get => "il"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
