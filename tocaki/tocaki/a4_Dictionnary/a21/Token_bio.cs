using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a21;

public class Token_bio : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "bio"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Collision avec byo"; }
    public override List<string> FrenchWordsAssociated { get => [""]; }
}
