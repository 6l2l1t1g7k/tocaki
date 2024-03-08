using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_qlE : LexicalToken
{ // TODO revoir le fichier qui décrit les nombres et les numéros
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "qlE"; }
    public override string DefinitionInTocaki { get => "∅5"; }
    public override string DefinitionInFrench { get => "cinq, 5"; }
    public override List<string> FrenchWordsAssociated { get => ["5"]; }
}
