using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_fo : LexicalToken
{
    public override string Phonetics { get => "fo"; }
    public override string DefinitionInTocaki { get => ","; }
    public override string DefinitionInFrench { get => "virgule, (séparateur (au moins pour les nombres avec partie décimale))"; }
    public override List<string> FrenchWordsAssociated { get => [","]; }

    public override List<Type> ParentConcepts { get => []; }
}
