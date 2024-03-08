using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_jM : LexicalToken
{
    public override string Phonetics { get => "jM"; }
    public override string DefinitionInTocaki { get => "li⋃li"; }
    public override string DefinitionInFrench { get => "désigne plusieurs personne à qui le locuteur parle; plusieurs « il », ils, eux"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
