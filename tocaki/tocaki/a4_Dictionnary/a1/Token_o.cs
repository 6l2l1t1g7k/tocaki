using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tocaki.a4_Dictionnary.a1;

public class Token_o : LexicalToken
{
    public override string Phonetics { get => "o"; } // TODO Q? il détecte automatiquement que c'est pas la peine de créer une string interne associé à Phonetics ?
    // par rapport à Pohonetics { get; }
    public override string DefinitionInTocaki { get => "[]-vuma-*"; }
    public override string DefinitionInFrench { get => "Marque du pluriels."; }
    public override List<string> FrenchWordsAssociated { get => []; }
}
