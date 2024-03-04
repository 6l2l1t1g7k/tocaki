using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_Fµ : LexicalToken
{
    public override string Phonetics { get => "Fµ"; }
    public override string DefinitionInTocaki { get => "F"; }
    public override string DefinitionInFrench { get => "« ath » anglais"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
