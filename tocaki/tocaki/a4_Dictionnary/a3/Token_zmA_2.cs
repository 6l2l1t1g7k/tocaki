using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_zmA : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "zmA"; }
    public override string DefinitionInTocaki { get => "zmA"; }
    public override string DefinitionInFrench { get => "un abu"; }
    public override List<string> FrenchWordsAssociated { get => ["abu"]; }
}
