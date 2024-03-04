using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_trN : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "trN"; }
    public override string DefinitionInTocaki { get => "36"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["36"]; }
}
