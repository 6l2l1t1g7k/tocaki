using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_ze : LexicalToken
{
    public override string Phonetics { get => "ze"; }
    public override string DefinitionInTocaki { get => "ze"; }
    public override string DefinitionInFrench { get => "Ati, opozisyM"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
