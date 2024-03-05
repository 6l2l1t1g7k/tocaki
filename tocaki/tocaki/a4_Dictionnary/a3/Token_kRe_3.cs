using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kRe : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kRe"; }
    public override string DefinitionInTocaki { get => "∘"; }
    public override string DefinitionInFrench { get => "loi rond, composition de deux application"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}