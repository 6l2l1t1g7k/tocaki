using tocaki.a4_DictionaryHolder;

namespace tocaki.a4_DictionnaryHolder.Dictionnary.a23;

public class Token_rusta : LexicalToken
{
    public Token_ruzwi ruzwi1 = new();
    public override List<Type> ParentConcepts => [typeof(Token_ruzwi)];
    public override string Phonetics => "rusta";
    public override string DefinitionInTocaki => $"{ruzwi1.Phonetics} qui vérifie que pour tout x de {ruzwi1.rumze1.EnsembleDeDepart} il existe un unique y de {ruzwi1.rumze1.EnsembleDarrive} tel que le couple (x, y) appartienne à {ruzwi1.rumze1.EnsembleDeLaRelation}.";
    public override string DefinitionInFrench => "";
    public override List<string> FrenchWordsAssociated => ["application", "fonction"];
}
