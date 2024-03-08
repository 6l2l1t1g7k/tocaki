using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_Special04 : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "€Be"; }
    public override string DefinitionInTocaki { get => "€"; }
    public override string DefinitionInFrench { get => "La lettre €, pour le son « sch » allemand."; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
