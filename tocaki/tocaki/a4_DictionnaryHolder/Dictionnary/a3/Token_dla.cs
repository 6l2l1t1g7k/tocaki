using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_dla : LexicalToken
{
    public override string Phonetics { get => "dla"; }
    public override string DefinitionInTocaki { get => "possessif singulier de qE (ja1⋃ja2)"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => ["notre"]; }

    public override List<Type> ParentConcepts { get => []; }
}
