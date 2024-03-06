using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_qli : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "qli"; }
    public override string DefinitionInTocaki { get => "∅0"; }
    public override string DefinitionInFrench { get => "zéro, 0"; }
    public override List<string> FrenchWordsAssociated { get => ["0"]; }
}
