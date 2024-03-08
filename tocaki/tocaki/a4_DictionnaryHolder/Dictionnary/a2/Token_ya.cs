using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_ya : LexicalToken
{
    public override string Phonetics { get => "ya"; }
    public override string DefinitionInTocaki { get => "∃"; }
    public override string DefinitionInFrench { get => "∃, quantificateur existentiel"; }
    public override List<string> FrenchWordsAssociated { get => []; }

    public override List<Type> ParentConcepts { get => []; }
}
