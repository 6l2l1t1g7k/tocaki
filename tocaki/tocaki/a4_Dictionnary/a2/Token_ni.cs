using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a2;

public class Token_ni : LexicalToken
{
    public override string Phonetics { get => "ni"; }
    public override string DefinitionInTocaki { get => "possessif singulier de qi (ri1⋃ri2)"; }
    public override string DefinitionInFrench { get => "leur"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
