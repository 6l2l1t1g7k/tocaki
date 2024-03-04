using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_ble : LexicalToken
{
    public override string Phonetics { get => "ble"; }
    public override string DefinitionInTocaki { get => "∅0"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["0", "zéro"]; }

    public override List<Type> ParentConcepts { get => []; }
}
