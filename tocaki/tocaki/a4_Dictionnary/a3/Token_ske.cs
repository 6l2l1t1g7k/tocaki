using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_ske : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "ske"; }
    public override string DefinitionInTocaki { get => "ske"; }
    public override string DefinitionInFrench { get => " Qui inspire l'aversion, le dégout, le rejet"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
