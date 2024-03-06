using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a21;

public class Token_dao : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "dao"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "les"; }
    public override List<string> FrenchWordsAssociated { get => ["les"]; }
}
