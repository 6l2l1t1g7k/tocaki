using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_zwe : LexicalToken
{
    public override List<Type> ParentConcepts { get => []; }
    public override string Phonetics { get => "zwe"; }
    public override string DefinitionInTocaki { get => "z"; }
    public override string DefinitionInFrench { get => "z"; }
    public override List<string> FrenchWordsAssociated { get => [""]; } // TODO cr�er la commande qui permet d'avoir toute les variations m�canique d'un morph�me de base nom, adjecti, adverbe ... formaliser tout �a
}
