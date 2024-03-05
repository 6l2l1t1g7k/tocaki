using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kmo : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kmo"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Concat�nation de morph�me"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}