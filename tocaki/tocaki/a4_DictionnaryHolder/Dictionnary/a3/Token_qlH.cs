using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_qlH : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "qlH"; }
    public override string DefinitionInTocaki { get => "∅8"; } // TODO problème de cohérence il y a aussi, il y a aussi blH pour dire ∅8 
    public override string DefinitionInFrench { get => "huit, 8"; }
    public override List<string> FrenchWordsAssociated { get => ["8"]; }
}
