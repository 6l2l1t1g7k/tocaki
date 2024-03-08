using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_jwi : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "jwi"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Couleur. TSL : 0;0;100 ; Hexadécimal : ffffff"; }
    public override List<string> FrenchWordsAssociated { get => ["blanc"]; }
}
