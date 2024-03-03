using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_zu : LexicalToken
{
    public override string Phonetics { get => "zu"; }
    public override string DefinitionInTocaki { get => "zu"; }
    public override string DefinitionInFrench { get => "équivalent de « ce », désigne un objet dans le contexte"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
