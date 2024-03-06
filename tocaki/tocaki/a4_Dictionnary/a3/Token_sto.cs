using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_sto : LexicalToken {
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "sto"; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "Intensité 4/10"; }
    public override List<string> FrenchWordsAssociated { get => ["faible"]; }

}
