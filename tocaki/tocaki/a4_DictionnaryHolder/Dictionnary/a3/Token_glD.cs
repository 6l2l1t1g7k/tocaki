using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_glD : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "glD"; }
    public override string DefinitionInTocaki { get => "glD"; }
    public override string DefinitionInFrench { get => "Note : Phrase courte ou fragmentaire destinée à garder mention de ce qui a été vu, lu ou entendu ou à le reconstituer."; }
    public override List<string> FrenchWordsAssociated { get => ["note"]; }
}
