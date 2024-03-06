using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_sla : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "sla"; }
    public override string DefinitionInTocaki { get => "sla"; }
    public override string DefinitionInFrench { get => "beau, qui suscite l’admiration"; }
    public override List<string> FrenchWordsAssociated { get => ["beau", "admirable"]; }
}
