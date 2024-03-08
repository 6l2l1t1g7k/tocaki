using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_rM : LexicalToken
{
    public override string Phonetics { get => "rM"; }
    public override string DefinitionInTocaki { get => "¬izomDrf a Dbje referAse"; }
    public override string DefinitionInFrench { get => "le « faux » logique"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
