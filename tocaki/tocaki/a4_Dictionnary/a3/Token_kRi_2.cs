using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kRi : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kRi"; }
    public override string DefinitionInTocaki { get => "⇐"; }
    public override string DefinitionInFrench { get => "implication réciproque"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
