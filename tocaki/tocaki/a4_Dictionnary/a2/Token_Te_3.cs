using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_Te_3 : LexicalToken
{
    public override string Phonetics { get => "Te"; }
    public override string DefinitionInTocaki { get => "T"; }
    public override string DefinitionInFrench { get => "« the » anglais"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
