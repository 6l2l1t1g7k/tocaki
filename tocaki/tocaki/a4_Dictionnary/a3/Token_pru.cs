using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_pru : LexicalToken
{
    public override string Phonetics { get => "pru"; }
    public override string DefinitionInTocaki { get => "pru"; }
    public override string DefinitionInFrench { get => "les choses qui ont une différence ave un autre objet de référence, différent, autre"; }
    public override List<string> FrenchWordsAssociated { get => ["différent"]; }

    public override List<Type> ParentConcepts { get => []; }
}
