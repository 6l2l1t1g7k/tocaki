namespace tocaki.a4_Dictionary.a2;

public class Token_qa : LexicalToken
{
    public override string Phonetics { get => "qa"; }
    public override string DefinitionInTocaki { get => "∈"; }
    public override string DefinitionInFrench { get => "∈,appartenir,être du type; exemple : je suis beau/juqasla"; }
    public override List<string> FrenchWordsAssociated { get => ["être"]; }
}
