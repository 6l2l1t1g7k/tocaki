using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_bca : LexicalToken
{
    public override string Phonetics { get => "bca"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Couleur. TSL : 120;100;50 ; Hexadécimal : 808000"; }
    public override List<string> FrenchWordsAssociated { get => ["vert foncé"]; }

    public override List<Type> ParentConcepts { get => []; }
}
