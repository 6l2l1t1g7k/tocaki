using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_kva : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "kva"; }
    public override string DefinitionInTocaki { get => "kva"; }
    public override string DefinitionInFrench { get => "famille fini ordonné d'éléments pris dans un alphabet"; }
    public override List<string> FrenchWordsAssociated { get => ["mot"]; }
}