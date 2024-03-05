using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_gnu : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gnu"; }
    public override string DefinitionInTocaki { get => "nan"; }
    public override string DefinitionInFrench { get => "Couleur : TSL:180;100;100 ; Hexadécimal : 00ffff"; }
    public override List<string> FrenchWordsAssociated { get => ["cyan"]; }
}
