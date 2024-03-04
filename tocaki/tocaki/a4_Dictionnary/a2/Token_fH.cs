using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_fH : LexicalToken
{
    public override string Phonetics { get => "fH"; }
    public override string DefinitionInTocaki { get => "fH"; }
    public override string DefinitionInFrench { get => "le verbe faire"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
