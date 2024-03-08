using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_dro : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "dro"; }
    public override string DefinitionInTocaki { get => "Couleur. TSL : 60;100;100 ; Hexadécimal : ffff00"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["jaune"]; }
}
