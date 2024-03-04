using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_fe : LexicalToken
{
    public override string Phonetics { get => "fe"; }
    public override string DefinitionInTocaki { get => "⊸,()"; }
    public override string DefinitionInFrench { get => "« de » désigne l'affectation d'une application à son paramètre"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
