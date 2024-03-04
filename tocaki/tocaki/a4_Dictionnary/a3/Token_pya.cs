using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_pya : LexicalToken
{
    public override string Phonetics { get => "pya"; }
    public override string DefinitionInTocaki { get => "pya"; }
    public override string DefinitionInFrench { get => "qui ne voit pas la lumière"; }
    public override List<string> FrenchWordsAssociated { get => ["aveugle"]; }

    public override List<Type> ParentConcepts { get => []; }
}
