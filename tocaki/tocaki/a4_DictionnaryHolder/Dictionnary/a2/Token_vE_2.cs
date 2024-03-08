using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_vE : LexicalToken
{
    public override string Phonetics { get => "vE"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => "marque usuelle de l’inverse, l’opposé"; }
    public override List<string> FrenchWordsAssociated { get => ["in-"]; }

    public override List<Type> ParentConcepts { get => []; }
}
