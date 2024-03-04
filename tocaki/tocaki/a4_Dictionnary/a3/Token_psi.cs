using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_psi : LexicalToken
{
    public override string Phonetics { get => "psi"; }
    public override string DefinitionInTocaki { get => "[]-rEglu"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
