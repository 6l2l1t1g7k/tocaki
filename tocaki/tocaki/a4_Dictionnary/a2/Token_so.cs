using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_so : LexicalToken
{
    public override string Phonetics { get => "so"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => "radical plutôt lié à la langue, écrit…."; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
