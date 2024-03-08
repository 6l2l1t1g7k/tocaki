using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a32;

public class Token_syoku : LexicalToken
{
    public override List<Type> ParentConcepts => [];
    public override string Phonetics => "syoku";
    public override string DefinitionInTocaki => "";
    public override string DefinitionInFrench => "proposition définie comme vraie à la base d'un système hypothético-déductif";
    public override List<string> FrenchWordsAssociated => ["axiome"];
}
