using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_sle : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "sle"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "marque des ordinaux, premier, deuxième, troisième…"; }
    public override List<string> FrenchWordsAssociated { get => ["-xième"]; }
}
