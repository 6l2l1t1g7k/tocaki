using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_sa : LexicalToken
{
    public override string Phonetics { get => "sa"; }
    public override string DefinitionInTocaki { get => "⟞"; }
    public override string DefinitionInFrench { get => "car, en raison de"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
