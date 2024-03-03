using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_si : LexicalToken
{
    public override string Phonetics { get => "si"; }
    public override string DefinitionInTocaki { get => "reglu-[]"; }
    public override string DefinitionInFrench { get => "marque de chainage « d’adjectif  générique », le mot caractérise le mot qui lui précède directement"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
