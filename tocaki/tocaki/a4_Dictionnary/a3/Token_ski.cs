using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_ski : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "ski"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "un peu comme la particule «-ité » indiquand une qualité dérivée d’un concept plutôt du genre adjectif"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
