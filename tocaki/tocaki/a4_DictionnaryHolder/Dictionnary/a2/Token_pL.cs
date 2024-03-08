using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_pL : LexicalToken
{
    public override string Phonetics { get => "pL"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => [""]; }

    public override List<Type> ParentConcepts { get => []; }
}
