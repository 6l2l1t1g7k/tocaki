using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a21;

public class Token_bao : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "bao"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "mes"; }
    public override List<string> FrenchWordsAssociated { get => ["mes"]; }
}
