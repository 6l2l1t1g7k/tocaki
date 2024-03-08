using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_fna : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "fna"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Couleur. TSL : 0;100;100 ; Hexadécimal : ff0000"; }
    public override List<string> FrenchWordsAssociated { get => ["rouge"]; }
}
