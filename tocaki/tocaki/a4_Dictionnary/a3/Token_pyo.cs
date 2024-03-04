using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_pyo : LexicalToken
{
    public override string Phonetics { get => "pyo"; }
    public override string DefinitionInTocaki { get => "pyo"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["important"]; }

    public override List<Type> ParentConcepts { get => []; }
}
