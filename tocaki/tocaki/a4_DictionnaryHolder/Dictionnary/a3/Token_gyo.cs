using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_gyo : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gyo"; }
    public override string DefinitionInTocaki { get => "⊥"; }
    public override string DefinitionInFrench { get => "contradiction logique"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
