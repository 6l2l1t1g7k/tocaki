using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_tlM : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "tlM"; }
    public override string DefinitionInTocaki { get => "⊤"; }
    public override string DefinitionInFrench { get => "tautologie logique"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
