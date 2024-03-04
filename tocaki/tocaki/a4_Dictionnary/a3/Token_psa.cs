using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_psa : LexicalToken
{
    public override string Phonetics { get => "psa"; }
    public override string DefinitionInTocaki { get => "psa"; }
    public override string DefinitionInFrench { get => "puissance/créature secondaire de nature sacré qui régit l’univers"; }
    public override List<string> FrenchWordsAssociated { get => ["ange"]; }

    public override List<Type> ParentConcepts { get => []; }
}
