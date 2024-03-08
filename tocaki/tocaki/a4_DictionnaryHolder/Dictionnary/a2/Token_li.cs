using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_li : LexicalToken
{
    public override string Phonetics { get => "li"; }
    public override string DefinitionInTocaki { get => "Possessif singulier de ji (ja⋃ri)"; }
    public override string DefinitionInFrench { get => ""; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
