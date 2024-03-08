using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_bda : LexicalToken
{
    public override string Phonetics { get => "bda"; }
    public override string DefinitionInTocaki { get => "bda"; }
    public override string DefinitionInFrench { get => "les choses qui suscite l’exécration"; }
    public override List<string> FrenchWordsAssociated { get => ["moche", "laid"]; }

    public override List<Type> ParentConcepts { get => []; }
}
