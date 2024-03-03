using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_special02 : LexicalToken
{
    public override string Phonetics { get => "&µ"; }
    public override string DefinitionInTocaki { get => "&"; }
    public override string DefinitionInFrench { get => "« r » anglais"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
