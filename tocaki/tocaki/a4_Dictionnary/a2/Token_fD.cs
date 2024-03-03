using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_fD : LexicalToken
{
    public override string Phonetics { get => "fD"; }
    public override string DefinitionInTocaki { get => "∅∅∅"; }
    public override string DefinitionInFrench { get => "Phonème a ne pas utiliser car il y a collision phonétique avec \"fo\""; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
