using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_qmu : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "qmu"; }
    public override string DefinitionInTocaki { get => "qmu"; }
    public override string DefinitionInFrench { get => "les choses qui sont possibles"; }
    public override List<string> FrenchWordsAssociated { get => ["possible"]; }
}
