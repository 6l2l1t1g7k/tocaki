using System.Drawing;
using tocaki.a4_Dictionary;

namespace tocaki.a4_Dictionnary.a3;

public class Token_bce : LexicalToken
{
    public override string Phonetics { get => "bce"; }
    public override string DefinitionInFrench { get => "Couleur. TSL : 120;100;100 ; Hexadécimal : 00ff00"; }
    public override List<string> FrenchWordsAssociated { get => ["vert primaire", "vert clair"]; }

    public override List<Type> ParentConcepts { get => [typeof(Color)]; } // TODO retrouver les couleurs et leur faire hériter du type "couleur" tocaki
}
