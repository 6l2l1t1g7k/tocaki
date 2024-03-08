using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_special02 : LexicalToken
{
    public override string Phonetics { get => "&µ"; }
    public override string DefinitionInTocaki { get => "&"; }
    public override string DefinitionInFrench { get => "« r » anglais"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
