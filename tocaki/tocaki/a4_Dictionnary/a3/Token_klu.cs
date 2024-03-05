using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_klu : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "klu"; }
    public override string DefinitionInTocaki { get => "⇍"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }
}