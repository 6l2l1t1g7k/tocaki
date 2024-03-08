using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a3;

public class Token_fti : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "fti"; }
    public override string DefinitionInTocaki { get => "4∅"; } // TODO revoir pour tout les autres numéro, il y a des 4∅ où je me suis trompé j'ai écrit genre ∅4
    public override string DefinitionInFrench { get => "quatre, 4"; }
    public override List<string> FrenchWordsAssociated { get => ["4"]; }
}
