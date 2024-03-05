using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_gRu : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gRu"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Dur à prononcer et collision avec \"gru\""; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
