using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_vlA : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "vlA"; }
    public override string DefinitionInTocaki { get => "⇔"; }
    public override string DefinitionInFrench { get => "équivalence"; }
    public override List<string> FrenchWordsAssociated { get => ["équivaux à"]; }
}
