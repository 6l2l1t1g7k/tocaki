using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_zu : LexicalToken
{
    public override string Phonetics { get => "zu"; }
    public override string DefinitionInTocaki { get => "zu"; }
    public override string DefinitionInFrench { get => "équivalent de « ce », désigne un objet dans le contexte"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
