using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_gRN : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gRN"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Dur à prononcer et collision avec \"grN\""; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
