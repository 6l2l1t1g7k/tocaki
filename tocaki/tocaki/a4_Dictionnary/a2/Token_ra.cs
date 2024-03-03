using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_ra : LexicalToken
{
    public override string Phonetics { get => "ra"; }
    public override string DefinitionInTocaki { get => "maRkLR du futuR"; }
    public override string DefinitionInFrench { get => "marqueur du futur"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
