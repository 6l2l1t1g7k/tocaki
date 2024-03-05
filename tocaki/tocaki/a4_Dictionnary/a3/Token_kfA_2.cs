using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kfA : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kfA"; }
    public override string DefinitionInTocaki { get => "kfA"; }
    public override string DefinitionInFrench { get => "le brutal, sec, peu avenant"; }
    public override List<string> FrenchWordsAssociated { get => ["brutal", "sec"]; }
}