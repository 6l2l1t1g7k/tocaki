using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_do6 : LexicalToken
{
    public override string Phonetics { get => "do"; }
    public override string DefinitionInTocaki { get => "¬,NvalidasyM"; }
    public override string DefinitionInFrench { get => "le « non » logique"; }
    public override List<string> FrenchWordsAssociated { get => new List<string>(); }

    public override List<Type> ParentConcepts { get => []; }
}
