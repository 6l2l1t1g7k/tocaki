using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_mu : LexicalToken
{
    public override string Phonetics { get => "mu"; }
    public override string DefinitionInTocaki { get => "possessif singulier de qu (fu1⋃fu2)"; }
    public override string DefinitionInFrench { get => "votre"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
