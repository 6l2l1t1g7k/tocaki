using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kno : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kno"; }
    public override string DefinitionInTocaki { get => "kno"; }
    public override string DefinitionInFrench { get => "l’accès difficile"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
