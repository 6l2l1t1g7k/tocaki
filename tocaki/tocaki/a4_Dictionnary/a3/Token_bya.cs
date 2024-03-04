using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_bya : LexicalToken
{
    public override string Phonetics { get => "bya"; }
    public override string DefinitionInTocaki { get => "ɞ"; }
    public override string DefinitionInFrench { get => "Jeton d'affectation"; }
    public override List<string> FrenchWordsAssociated { get => ["soit", "affectation", "définition"]; }

    public override List<Type> ParentConcepts { get => []; }
}
