using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_blN : LexicalToken
{
    public override string Phonetics { get => "blN"; }
    public override string DefinitionInTocaki { get => "∅6"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["6", "six"]; }

    public override List<Type> ParentConcepts { get => []; }
}
