using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a21;

public class Token_reo : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "reo"; }
    public override string DefinitionInTocaki { get => "marque de gratitude envers quelqu’un ou quelque chose"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["merci"]; }
}
