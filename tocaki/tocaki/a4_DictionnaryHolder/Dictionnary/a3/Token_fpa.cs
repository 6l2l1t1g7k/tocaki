using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_fpa : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "fpa"; }
    public override string DefinitionInTocaki { get => "fpa"; }
    public override string DefinitionInFrench { get => "mot, lemme, entré lexicale"; }
    public override List<string> FrenchWordsAssociated { get => ["mot"]; }
}
