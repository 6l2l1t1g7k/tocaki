using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kse : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kse"; }
    public override string DefinitionInTocaki { get => "20"; }
    public override string DefinitionInFrench { get => "vingt, 20"; }
    public override List<string> FrenchWordsAssociated { get => ["20"]; }
}
