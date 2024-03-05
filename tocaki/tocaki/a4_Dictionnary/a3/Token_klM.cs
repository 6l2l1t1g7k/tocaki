using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_klM : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "klM"; }
    public override string DefinitionInTocaki { get => "¬∧,↑"; }
    public override string DefinitionInFrench { get => "¬∧,nand,↑, non et"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}