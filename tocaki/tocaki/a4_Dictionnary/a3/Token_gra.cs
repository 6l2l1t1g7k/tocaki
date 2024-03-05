using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_gra : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gra"; }
    public override string DefinitionInTocaki { get => "11"; }
    public override string DefinitionInFrench { get => "onze, 11"; }
    public override List<string> FrenchWordsAssociated { get => ["11"]; }
}
