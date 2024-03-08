using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_stRa : LexicalToken
{
    public override string Phonetics { get => "ble"; }
    public override string DefinitionInTocaki { get => "∅0"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["0", "zéro"]; }

    public override List<Type> ParentConcepts { get => []; }
}
