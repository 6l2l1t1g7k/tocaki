using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_gzo : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gzo"; }
    public override string DefinitionInTocaki { get => "⊕"; }
    public override string DefinitionInFrench { get => "ou exclusif"; }
    public override List<string> FrenchWordsAssociated { get => ["ou"]; }
}
