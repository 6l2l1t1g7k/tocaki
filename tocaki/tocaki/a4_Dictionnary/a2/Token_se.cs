using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_se : LexicalToken
{
    public override string Phonetics { get => "se"; }
    public override string DefinitionInTocaki { get => "se"; }
    public override string DefinitionInFrench { get => "suffixe marqueur du passé (grammaire)"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
