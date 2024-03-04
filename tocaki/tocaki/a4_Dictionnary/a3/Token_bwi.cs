using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_bwi : LexicalToken
{
    public override string Phonetics { get => "bwi"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Couleur. TSL : 300;100;100 ; Hexadécimal : ff00ff"; }
    public override List<string> FrenchWordsAssociated { get => ["rose"]; }

    public override List<Type> ParentConcepts { get => []; }
}
