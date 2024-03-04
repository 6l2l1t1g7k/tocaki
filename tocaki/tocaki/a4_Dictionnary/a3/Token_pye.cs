using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_pye : LexicalToken
{
    public override string Phonetics { get => "pye"; }
    public override string DefinitionInTocaki { get => "NtGryLR"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["intérieur", "dedans"]; }

    public override List<Type> ParentConcepts { get => []; }
}
