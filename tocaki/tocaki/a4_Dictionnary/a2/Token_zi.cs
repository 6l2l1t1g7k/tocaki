using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_zi : LexicalToken
{
    public override string Phonetics { get => "zi"; }
    public override string DefinitionInTocaki { get => "<"; }
    public override string DefinitionInFrench { get => "marque du comparatif inférieur, moins, plus petit que"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
