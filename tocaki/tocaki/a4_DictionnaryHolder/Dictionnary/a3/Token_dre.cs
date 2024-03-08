using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_dre : LexicalToken
{
    public override List<Type> ParentConcepts => [];
    public override string Phonetics { get => "dre"; } // TODO Q? outils de refacto pour écrire       public override string Phonetics => "dre";
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "marqueur de l’intensité 7/10"; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
