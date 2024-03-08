using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a2;

public class Token_go : LexicalToken
{
    public override string Phonetics { get => "go"; }
    public override string DefinitionInTocaki { get => ""; }
    public override string DefinitionInFrench { get => "Le positif agréable."; } // TODO en C# comment aller faire des modifications dans le code source ? Au minimum être capable de pointer facilement sur l'emplacement des données
    public override List<string> FrenchWordsAssociated { get => ["bien"]; }

    public override List<Type> ParentConcepts { get => []; }
}
