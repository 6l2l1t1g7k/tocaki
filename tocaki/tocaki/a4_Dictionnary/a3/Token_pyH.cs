using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_pyH : LexicalToken
{
    public override string Phonetics { get => "pyH"; }
    public override string DefinitionInTocaki { get => "pyH"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["avoir"]; }

    public override List<Type> ParentConcepts { get => []; }
}
