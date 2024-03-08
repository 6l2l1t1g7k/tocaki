using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_zle : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "zle"; }
    public override string DefinitionInTocaki { get => "zle"; }
    public override string DefinitionInFrench { get => "l’abstrait, le monde des idées"; }
    public override List<string> FrenchWordsAssociated { get => ["abstrait"]; }
}
