namespace tocaki.a4_Dictionary.a2;

public class Token_qu : LexicalToken
{
    public override string Phonetics { get => "qu"; }
    public override string DefinitionInTocaki { get => "tu⋃tu"; }
    public override string DefinitionInFrench { get => "désigne plusieurs « tu » à qui le locuteur parle, vous"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
