using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_gna : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "gna"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Balise qui indique un nombre négatif."; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
