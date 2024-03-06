using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_vcA : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public List<Type> LinkedConcepts { get => [typeof(Token_vrN)]; }
    public override string Phonetics { get => "vcA"; }
    public override string DefinitionInTocaki { get => "⋉"; }
    public override string DefinitionInFrench { get => "(a vca b=b) = (a n'influence pas b)"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
