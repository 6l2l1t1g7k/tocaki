using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_special01 : LexicalToken // TODO comment commer toutes ces classes élémentaires ?
{
    public override string Phonetics { get => "$µ"; }
    public override string DefinitionInTocaki { get => "$"; }
    public override string DefinitionInFrench { get => "« gn » de parking"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
