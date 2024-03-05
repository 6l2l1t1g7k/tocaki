using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_gli : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gli"; }
    public override string DefinitionInTocaki { get => "[]-rEglu"; }
    public override string DefinitionInFrench { get => "Intensité 3/10"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
