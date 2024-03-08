using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_bRA : LexicalToken
{
    public override string Phonetics { get => "bRA"; }
    public override string DefinitionInTocaki { get => "∅∅∅"; }
    public override string DefinitionInFrench { get => "Collison phonétique avec \"brA\"."; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
