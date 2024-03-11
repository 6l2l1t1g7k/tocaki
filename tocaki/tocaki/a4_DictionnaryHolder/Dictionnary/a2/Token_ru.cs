using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_ru : LexicalToken
{
    public override string Phonetics { get => "ru"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => "Marqueur réservé pour des mots mathématiques"; }
    public override List<string> FrenchWordsAssociated { get => ["mathématiques"]; }

    public override List<Type> ParentConcepts { get => []; }
}
