using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_bwN : LexicalToken
{
    public override string Phonetics { get => "bwN"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Couleur. TSL : 340;100;100 ; Hexadécimal : ff5500"; }
    public override List<string> FrenchWordsAssociated { get => ["bordeau"]; }

    public override List<Type> ParentConcepts { get => []; }
}
