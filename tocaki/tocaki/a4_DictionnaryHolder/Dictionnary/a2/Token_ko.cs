using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_ko : LexicalToken
{
    public override string Phonetics { get => "ko"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Non, négation, marque de l’invalidation"; }
    public override List<string> FrenchWordsAssociated { get => ["non"]; }

    public override List<Type> ParentConcepts { get => []; }
}
